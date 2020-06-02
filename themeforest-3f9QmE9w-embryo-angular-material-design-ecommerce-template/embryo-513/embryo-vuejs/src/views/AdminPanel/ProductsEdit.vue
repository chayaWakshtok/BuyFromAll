<template>
	<div class="emb-product-edit"  v-if="selectedProduct != null">
		<v-row>
			<v-col cols="12" sm="9" md="10" lg="10" class="mx-auto">
				<v-row>
					<v-col cols="12" sm="12" md="6" lg="6" >
						<div class="product-images-wrap d-flex">
							<div class="product-images mr-4">
								<div class="thumb-wrap ml-auto" for="upload" 
									v-for="(img,key) in selectedProduct.image_gallery" 
									:key="key"
									@mouseover="doHover(img)"
								>
									<v-img :src="img" style="height: 70px;"  />
									<div class="edit-btn d-flex justify-center align-center">
										<v-icon dark>edit</v-icon>
									</div>
									<input type="file" id="upload" accept="image/*" class="upload-img">
								</div>
							</div>
							<div class="product-preview-wrap">
									<v-img :src="selectedImage" style="width: 100%;" />
							</div>
						</div>
					</v-col>
					<v-col cols="12" sm="12" md="6" lg="6" class="content-wrap pl-md-6">
						<router-link class="pt-4 d-block font-weight-medium" to="/admin-panel/products">Back to Products
						</router-link>
						<v-text-field prepend-icon="edit" class="name-input" v-model="selectedProduct.name" required></v-text-field>
						<v-text-field prepend-icon="edit" class="price-input" v-model="selectedProduct.price" required></v-text-field>
						<v-text-field prepend-icon="edit" label="Availablity" v-model="selectedProduct.availablity" required></v-text-field>
						<v-text-field prepend-icon="edit" label="Product Code :" v-model="selectedProduct.product_code" required>
						</v-text-field>
						<v-text-field prepend-icon="edit" label="Tags :" v-model="selectedProduct.tags" required></v-text-field>
						<v-text-field prepend-icon="edit" label="Description" v-model="selectedProduct.description" required></v-text-field>
						<v-text-field prepend-icon="edit" label="Features points" v-model="selectedProduct.features" required></v-text-field>
						<ul class="list-inline">
							<span class="d-block edit-text mb-2"><div class="v-input__icon v-input__icon--prepend mr-3"><i aria-hidden="true" class="v-icon notranslate material-icons theme--light">edit</i></div>Color Variants</span>
							<li class="d-inline-block px-2" v-for="(color,key) in colors" :key="key">
								<v-checkbox :label="color" class="ma-0 pa-0"></v-checkbox>
							</li>
						</ul>
						<ul class="list-inline">
							<span class="d-block edit-text mb-2"><div class="v-input__icon v-input__icon--prepend mr-3"><i aria-hidden="true" class="v-icon notranslate material-icons theme--light">edit</i></div>Size Variants</span>
							<li class="d-inline-block px-2" v-for="(size,key) in sizes" :key="key">
								<v-checkbox :label="size" class="ma-0 pa-0"></v-checkbox>
							</li>
						</ul>
						<v-text-field class="mb-4 border-bottom" prepend-icon="edit" value="5" type="number" label="Total Products"></v-text-field>
						<div class="d-block">
							<v-btn color="accent" class="mx-3" large>Save</v-btn>
							<v-btn color="white" large>Discard</v-btn>
						</div>
					</v-col>
				</v-row>
			</v-col>
		</v-row>
	</div>
</template>

<script>
import api from "Api";

export default {
  data() {
    return {
      checkbox: false,
      products: null,
      selectedProduct: null,
      selectedImage: null,
      title: "",
      id: "",
      colors: ["Red", "Blue", "Yellow", "Green"],
      sizes: ["28", "30", "32", "34", "36", "38", "40"]
    };
  },
  mounted() {
    this.getProductsData();
    this.title = this.$route.params.title;
    this.id = this.$route.params.id;
  },
  methods: {
    getProductsData() {
      api
        .get("products.json")
        .then(response => {
          this.products = response.data;
          if (this.title != null && this.id != null) {
            if (
              Object.keys(this.products).length > 0 &&
              typeof this.products[this.title] != "undefined"
            ) {
              for (let i = 0; i < this.products[this.title].length; i++) {
                if (this.products[this.title][i].id == this.id) {
                  this.selectedProduct = this.products[this.title][i];
                  this.selectedImage = this.selectedProduct.image;
                  break;
                }
              }
            }
          }
        })
        .catch(error => {
          console.log(error);
        });
    },
    /* for toggling image **/
    doHover(image) {
      this.selectedImage = image;
    }
  }
};
</script>
