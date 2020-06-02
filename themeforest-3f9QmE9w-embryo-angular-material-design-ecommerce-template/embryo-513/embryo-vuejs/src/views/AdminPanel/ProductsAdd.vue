<template>
	<div class="emb-product-add">
		<v-row>
			<v-col cols="12" sm="9" md="10" lg="10" class="mx-auto">
				<v-row>
					<v-col cols="12" sm="12" md="6" lg="6" >
						<div class="product-images-wrap d-flex">
							<div class="product-images mr-4">
								<div class="thumb-wrap" for="upload" v-for="(img,key) in 4" :key="key">
									<v-img src="https://via.placeholder.com/625x800" height="70" />
									<div class="edit-btn d-flex justify-center align-center">
										<v-icon dark>add</v-icon>
									</div>
									<input type="file" id="upload" accept="image/*" class="upload-img">
								</div>
							</div>
							<div class="product-preview-wrap">
								<v-img src="https://via.placeholder.com/625x800" style="width: 100%;" />
							</div>
						</div>
					</v-col>
					<v-col cols="12" sm="12" md="6" lg="6" class="content-wrap pl-md-6">
						<router-link class="pt-4 d-block font-weight-medium" to="/admin-panel/products">Back to Products
						</router-link>
	
						<v-text-field prepend-icon="add" class="name-input" placeholder="Add product Name"></v-text-field>
						<v-text-field prepend-icon="add" class="price-input" placeholder="Add Price"></v-text-field>
						<v-text-field prepend-icon="add" label="Availablity"></v-text-field>
						<v-text-field prepend-icon="add" label="Product Code :"></v-text-field>
						<v-text-field prepend-icon="add" label="Tags :"></v-text-field>
						<v-text-field prepend-icon="add" label="Description"></v-text-field>
						<v-text-field prepend-icon="add" label="Featured points"></v-text-field>
						<v-text-field class="mb-4 border-bottom" prepend-icon="add" value="5" type="number" label="Total Products"></v-text-field>
						<v-btn color="accent" class="mx-3" large>Create</v-btn>
						<v-btn color="white" large>Discard</v-btn>
					</v-col>
				</v-row>
			</v-col>
		</v-row>
	</div>
</template>