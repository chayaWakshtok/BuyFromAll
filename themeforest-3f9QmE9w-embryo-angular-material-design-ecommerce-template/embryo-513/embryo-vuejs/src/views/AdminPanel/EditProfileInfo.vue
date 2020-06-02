<template>
   <div>
      <div class="editInfo-wrap emb-card pa-4" v-if="$route.params.title=='edit' && $route.query.type=='info' ">
         <div>
            <h4>Edit Profile Information</h4>
            <v-form ref="form" v-model="valid" class="mb-2">
               <v-layout row wrap>
                  <v-flex xs12 sm12 md12 lg6 xl6>
                     <v-layout row wrap px-6>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-text-field label="First Name" :rules="inputRules.basictextRules"></v-text-field>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-text-field label="Last Name" :rules="inputRules.basictextRules"></v-text-field>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-radio-group
                           v-model="radioGroup"
                           :mandatory="true"
                           >
                           <v-radio
                              v-for="gender in radios"
                              :key="gender.type"
                              :value="gender.type"
                           >
                           <label
                                 :rules="inputRules.basictextRules"
                              slot="label"
                           >
                              {{ gender.type }}
                           </label>
                           </v-radio>
                           </v-radio-group>

                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-menu
                              ref="menu"
                              :close-on-content-click="false"
                              v-model="menu"
                              :nudge-right="40"
                              transition="scale-transition"
                              offset-y
                              min-width="290px"
                           >
                          		<template v-slot:activator="{ on }">
											<v-text-field
												v-model="date"
												label="Birthday date"
												append-icon="event"
												readonly
												v-on="on"
												:rules="inputRules.basictextRules"
											></v-text-field>
										</template>
                              <v-date-picker
                                 ref="picker"
                                 v-model="date"
                                 @change="save"
                              ></v-date-picker>
                           </v-menu>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-text-field label="Mobile No" :rules="inputRules.basictextRules"></v-text-field>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-text-field label="Location" :rules="inputRules.basictextRules"></v-text-field>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 py-1>
                           <v-text-field label="Email" :rules="emailRules"></v-text-field>
                        </v-flex>
                        <v-flex xs12 sm12 md12 lg12 xl12 pt-1 pb-0>
                           <v-btn class="accent mx-0 mb-4" @click.stop.prevent="saveDetails">Save</v-btn>
                        </v-flex>
                     </v-layout>
                  </v-flex>
                  <v-flex xs12 sm12 md6 lg6 xl6 user-bg edit-profile hidden-md-and-down>
                  </v-flex>
               </v-layout>
            </v-form>
         </div>
      </div>
      
   </div>
</template>

<script>
	export default{
   	data () {
      	return {
            val: '',
          	radios: [
					{
						type:'Male'
					},
					{
						type:'Female'
					}
				],
            radioGroup: 'Male',
         	valid: false,
          	inputRules: {
               basictextRules: [v => !!v || 'This field should not be empty']
            },
            emailRules: [
               v => !!v || 'E-mail is required',
               v => /.+@.+/.test(v) || 'E-mail must be valid'
            ],
            genders:[
               {
                  key:"Male"
               },
               {
                  key:"Female"
               },
            ],
            date: new Date().toISOString().substr(0, 10),
            menu: false,
            modal: false,
            menu2: false
         }
      },
      watch: {
         menu (val) {
         val && this.$nextTick(() => (this.$refs.picker.activePicker = 'YEAR'))
         }
      },
      methods: {
        saveDetails(){
				this.$refs.form.validate()
            if(this.valid == true){
               this.$snotify.success('Your account information updated succesfully!',{
                  closeOnClick: false,
                  pauseOnHover: false,
                  timeout: 1000,
                  showProgressBar:false,
               });
               setTimeout(() => {
                  this.$router.push({ path: '/admin-panel/account/profile' });
               }, 50);
				}
         },
         save (date) {
            this.$refs.menu.save(date)
         }
      }
   }
</script>