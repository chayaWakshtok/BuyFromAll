<template>
	<div>
		<div class="product-item-wrap emb-card"  >
			<div class="thumb-warp">
				<img alt="product" height="800" width="626" :src="data.image" >
				
				<div class="wishlist-icon">
					<v-btn @click="deleteItem(data)" icon >
						<v-icon class="grey--text">delete</v-icon>
					</v-btn>
				</div>

				<router-link :to="'/admin-panel/product-edit/'+data.type+'/'+data.id">
					<div class="add-to-cart">
						<v-btn
							class="accent"
							small icon
						>
							<v-icon>edit</v-icon>
						</v-btn>
					</div>
				</router-link>

			</div>
			<div class="emb-card-content pa-4">
				<h5 class="font-weight-medium text-capitalize">{{data.name}}</h5>
				<div class="inline-block">
					<p>{{data.category}}</p>
				</div>
				<div class="emb-meta-info layout align-center justify-space-between">
					<div class="inline-block">
						<h6 class="accent--text">
							<emb-currency-sign></emb-currency-sign>{{data.price}}
						</h6>
					</div>
				</div>
			</div>
		</div>
		<emb-delete-confirmation-2
			ref="deleteConfirmationDialog"
			messageTitle="Are You Sure You Want To Delete?"
			messageDescription="Are you sure you want to delete this product permanently?"
			@onConfirm="onDeleteItemFromProductsList"
			btn1="Cancel"
			btn2="Yes"
		>
		</emb-delete-confirmation-2>
	</div>
</template>

<script>
export default {
  props: ["data", "deleteProduct"],
  data() {
    return {
      selectedItem: null
    };
  },
  methods: {
    deleteItem(data) {
      this.$refs.deleteConfirmationDialog.openDialog();
      this.selectedItem = data;
    },
    onDeleteItemFromProductsList() {
      this.$refs.deleteConfirmationDialog.close();
      this.$emit("deleteProduct", this.selectedItem);
    }
  }
};
</script>