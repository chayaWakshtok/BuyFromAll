<template>
	<div class="mr-3">
		<v-menu transition="scale-transition" class="cart" min-width="300" max-width="300" offset-y light>
			<template v-slot:activator="{ on }">
				<v-btn class="cart-btn" fab dark small color="accent" v-on="on">
					<v-badge right large color="accent">
						<template v-if="cart.length > 0">
							<span slot="badge">{{cart.length}}</span>
						</template>
						<v-icon dark>shopping_cart</v-icon>
					</v-badge>
				</v-btn>
			</template>
			<div v-if="cart && cart.length > 0" class="cart-menu-list white">
				<emb-perfect-scrollbar class="scroll-area" style="max-height:280px">
					<v-list class="cart-list-items py-0" v-for="(cart, index) in cart" :key="index">
						<v-layout row wrap align-center cart-item ma-0>
							<v-flex sm12 md12 lg12 xl12 pa-0>
								<v-layout row wrap align-center class="ma-0">
									<v-flex xs3 sm3 md3 lg3 xl3 pa-0>
										<img :src="cart.image" width="60" height="70">
									</v-flex>
									<v-flex xs9 sm9 md9 lg9 xl9 pa-0>
										<div class="pl-1">
											<h6 class="word-wrap-break">{{cart.name}}</h6>
											<span>
												<emb-currency-sign></emb-currency-sign>{{cart.price * cart.quantity}}
											</span>
										</div>
									</v-flex>
									<v-flex sm4 md4 lg4 xl4 text-center pa-0 cart-action>
										<v-btn class="primary d-inline-block" icon @click.stop="dialog = true"
											@click="deleteProductFromCart(cart)">
											<v-icon>remove_shopping_cart</v-icon>
										</v-btn>
										<v-btn class="primary d-inline-block ml-2 d-inline-flex align-items-center" icon
											to="/cart">
											<v-icon>edit</v-icon>
										</v-btn>
									</v-flex>
								</v-layout>
							</v-flex>
						</v-layout>
					</v-list>
				</emb-perfect-scrollbar>
				<emb-delete-confirmation ref="deleteConfirmationDialog"
					message="Are you sure you want to delete this product?" @onConfirm="onDeleteProductFromCart">
				</emb-delete-confirmation>
				<v-layout align-center pa-3>
					<v-btn class="accent white--text" block to="/checkout">Checkout</v-btn>
				</v-layout>
			</div>
			<div v-else class="text-center white pa-6">
				<v-icon size="31" class="accent--text">
					shopping_cart
				</v-icon>
				<h5>No Product Found</h5>
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
			...mapGetters(["cart", "selectedCurrency", "currencies"]),
			getTotalPrice() {
				let totalPrice = 0;
				if (this.cart.length > 0) {
					for (const item of this.cart) {
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
			deleteProductFromCart(product) {
				this.$refs.deleteConfirmationDialog.openDialog();
				this.selectDeletedProduct = product;
			},
			onDeleteProductFromCart() {
				this.$refs.deleteConfirmationDialog.close();
				this.$snotify.success('Product Removing from cart', {
					closeOnClick: false,
					pauseOnHover: false,
					timeout: 1000,
				});
				this.$store.dispatch(
					"onDeleteProductFromCart",
					this.selectDeletedProduct
				);
			}
		}
	}
</script>