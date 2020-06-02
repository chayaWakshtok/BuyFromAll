<template>
   <div class="emb-card pa-4">
      <v-dialog max-width="500px" class="pa-4" v-model="open">
			<template v-slot:activator="{ on }">
				<v-btn color="primary" slot="activator" v-on="on" @click.stop="open = true" >
					Add Users
				</v-btn>
			</template>	
			<v-card>
				<v-card-title
					class="h4"
				>
				Add New User
				</v-card-title>
				<v-card-text>
					<v-form ref="form" v-model="valid" lazy-validation >
						<v-text-field v-model="name"
							:rules="nameRules" label="Name" required ></v-text-field>
				
						<v-text-field v-model="email" :rules="emailRules" 
							label="E-mail" required ></v-text-field>
				
						<v-select v-model="select" :items="items"
							:rules="[v => !!v || 'Item is required']"
							label="Access Type" required ></v-select>

						<v-btn color="primary" class="mr-3" @click="open = false">Close</v-btn>

						<v-btn :disabled="!valid" color="error" 
							@click="addItemToCollaborationList({'image':'/static/images/user.png','name':name,'email':email,'access':select})">
							Submit
						</v-btn>
					</v-form>
				</v-card-text>
			</v-card>
      </v-dialog>
      <template>
         <v-data-table
            :headers="headers"
				:items="collaborationData"
				hide-default-footer
         >
				<template v-slot:item.image="{ item }">
               <img :src="item.image" width="40">
            </template>
				<template v-slot:item.action="{ item }">
					<v-btn icon color="grey" small>
						<v-icon class="error--text" @click="deleteItemFromCollaborationList(item)">delete</v-icon>
					</v-btn>
				</template>	
         </v-data-table>
      </template>
      <emb-delete-confirmation-2
         ref="deleteConfirmationDialog"
         messageTitle="Are you sure you want to delete?"
         messageDescription="Are you sure you want to delete this user permanently?"
         @onConfirm="ondeleteItemFromCollaborationList"
         btn1="Cancel"
         btn2="Yes"
      >
      </emb-delete-confirmation-2>
   </div>
</template>

<script>
import api from "Api";

export default {
  data() {
    return {
      collaborationList: null,
      open: false,
      select: null,
      valid: true,
      items: [{ text: "Admin" }, { text: "Write" }, { text: "Read" }],
      name: "",
      nameRules: [v => !!v || "Name is required"],
      email: "",
      emailRules: [
        v => !!v || "E-mail is required",
        v => /.+@.+/.test(v) || "E-mail must be valid"
      ],
      selectRules: [v => !!v || "Item is required"],
      loader: true,
      collaborationData: [],
      headers: [
        {
          text: "Image",
          sortable: false,
          value: "image"
        },
        {
          text: "Name",
          sortable: false,
          value: "name"
        },
        {
          text: "Email",
          sortable: false,
          value: "email"
        },
        {
          text: "Access",
          sortable: false,
          value: "access"
        },
        {
          text: "Action",
          sortable: false,
          value: "action"
        }
      ],
      selectDeletedItem: null
    };
  },
  mounted() {
    this.getCollaborationData();
  },
  methods: {
    getCollaborationData() {
      api
        .get("collaborationData.json")
        .then(response => {
          this.collaborationList = response.data;
          this.collaborationList.forEach(element => {
            this.collaborationData.push(element);
          });
        })
        .catch(error => {
          console.log(error);
        });
    },
    addItemToCollaborationList(item) {
      if (this.$refs.form.validate()) {
        this.collaborationData.push(item);
        this.open = false;
        this.$refs.form.reset();
      } else {
        console.log("Invalid Inputs");
      }
    },

    deleteItemFromCollaborationList(item) {
      this.$refs.deleteConfirmationDialog.openDialog();
      this.selectDeletedItem = item;
    },
    ondeleteItemFromCollaborationList() {
      this.$refs.deleteConfirmationDialog.close();
      let index = this.collaborationData.indexOf(this.selectDeletedItem);
      this.collaborationData.splice(index, 1);
    }
  }
};
</script>