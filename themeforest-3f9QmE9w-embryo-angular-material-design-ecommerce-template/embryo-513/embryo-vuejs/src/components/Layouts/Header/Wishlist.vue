<template>
	<div class="mr-3">
		<v-menu transition="scale-transition" class="wishlit-menu-wrap" max-width="300" min-width="300" offset-y light>
			<template v-slot:activator="{ on }">
				<v-btn class="wishlist-btn" fab dark small color="accent" v-on="on">
						<v-badge right large color="accent">
							<template  v-if="wishlist.length > 0">
								<span slot="badge">{{wishlist.length}}</span>
							</template>
							<v-icon dark>favorite</v-icon>
						</v-badge>
					</v-btn>
			</template>
			<div class="text-center white pa-6" v-if="wishlist == ''">
				<v-icon size="31" class="accent--text">
					shopping_cart
				</v-icon>
				<h5>No Product Found</h5>
			</div>
			<div v-else class="wishlist-menu white">
				<emb-perfect-scrollbar class="scroll-area" style="max-height:280px">
					<v-list class="wishlist-cart-items py-0" v-for="(wishlist, index) in wishlist" :key="index">
						<v-layout row wrap align-center cart-item ma-0>
							<v-flex sm12 md12 lg12 xl12 pa-0>
								<v-layout row wrap align-center ma-0>
									<v-flex xs3 sm3 md3 lg3 xl3 pa-0>
										<img :src="wishlist.image" width="60" height="77">
									</v-flex>
									<v-flex xs9 sm9 md9 lg9 xl9 pa-0>
										<div class="pl-1">
											<h6 class="mb-0 word-wrap-break">{{wishlist.name}}</h6>
											<span>
												<emb-currency-sign></emb-currency-sign>{{wishlist.price}}
											</span>
										</div>
									</v-flex>
									<v-flex sm4 md4 lg4 xl4 text-center pa-0 cart-action>
										<v-btn class="primary d-inline-block" icon @click.stop="dialog = true"
											@click="deleteProductFromWishlist(wishlist)">
											<v-icon> remove_shopping_cart </v-icon>
										</v-btn>
										<v-btn class="primary d-inline-block ml-2 d-inline-flex align-items-center" icon to="/cart">
											<v-icon>edit</v-icon>
										</v-btn>
									</v-flex>
								</v-layout>
							</v-flex>
						</v-layout>
					</v-list>
				</emb-perfect-scrollbar>
				<emb-delete-confirmation ref="deleteConfirmationDialog"
					message="Are you sure you want to delete this product?" @onConfirm="onDeleteProductFromWishlist">
				</emb-delete-confirmation>
				<v-layout align-center pa-3>
					<v-btn class="accent white--text" block @click="addAllWishlistItemToCart">Add all to cart</v-btn>
				</v-layout>
			</div>
		</v-menu>
	</div>
</template>

<script>
	import { mapGetters } from 'vuex';
	import VuePerfectScrollbar from 'vue-perfect-scrollbar';

	export default {
		components: {
			embPerfectScrollbar: VuePerfectScrollbar,
		},
		data() {
			return {
				selectDeletedProduct: null,
				settings: {
					maxScrollbarLength: 160
				}
			};
		},
		computed: {
			...mapGetters(["wishlist", "cart"]),
			/**
			 * method for claculating total price
			*/
			getTotalPrice() {
				let totalPrice = 0;
				if (this.wishlist.length > 0) {
					for (const item of this.wishlist) {
						totalPrice += item.total;
					}
					return totalPrice.toFixed(2);
				}
				else {
					return totalPrice;
				}
			}
		},
		methods: {
			/**
			 * method for adding all wishlist item to cart
			*/
			addAllWishlistItemToCart() {
				this.$snotify.success('Product adding to the cart', {
					closeOnClick: false,
					pauseOnHover: false,
					timeout: 1000,
					showProgressBar: false,
				});
				setTimeout(() => {
					this.$store.dispatch("addAllWishlistItemToCart");
				}, 2000);
			},
			/**
			 * method for deleting item from wishlist 
			*/
			deleteProductFromWishlist(product) {
				this.$refs.deleteConfirmationDialog.openDialog();
				this.selectDeletedProduct = product;
			},
			/**
			 * method for showing notification after delteion of item from  wishlist
			*/
			onDeleteProductFromWishlist() {
				this.$refs.deleteConfirmationDialog.close();
				this.$snotify.success('Product Removing from wishlist', {
					closeOnClick: false,
					pauseOnHover: false,
					timeout: 1000,
					showProgressBar: false,
				});
				this.$store.dispatch("onDeleteProductFromWishlist", this.selectDeletedProduct);
			}
		}
	}
</script>