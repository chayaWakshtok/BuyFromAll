<template>
   <div class="emb-payment-wrap">
		<emb-page-title heading="Payment Information"></emb-page-title>
		<div class="emb-payment-content section-gap overflow-x-hidden">
			<v-container grid-list-xl py-0>
				<template v-if="cart.length > 0">
					<emb-sidebar-panel class="mb-12"></emb-sidebar-panel>
					<v-expansion-panels v-model="panel" multiple >
						<v-expansion-panel>
							<shipping-address @changeStepOneForm="enableStepOneForm"></shipping-address>
						</v-expansion-panel>
						<v-expansion-panel :disabled="!stepOneFormValid" :class="{'contracted': !stepOneFormValid}">
							<promo-codes @changePanel="changePanelValue"></promo-codes>
						</v-expansion-panel>
						<v-expansion-panel :disabled="!stepOneFormValid" :class="{'contracted': !stepOneFormValid}">
							<payment-option></payment-option>
						</v-expansion-panel>
					</v-expansion-panels>	
				</template>
				<template v-else>
					<div class="text-center">
						<div class="mb-6">
							<img  alt="cart-empty" height="128" src="/static/images/empty-cart.png" width="128">
						</div>
						<h4 > Your Shopping Bag is empty.</h4>
						<router-link class="primary--text" to="/">Go to Shopping</router-link>
					</div>
				</template>
			</v-container>
		</div>
   </div>
</template>

<script>
import ShippingAddress from './Component/ShippingAddress'
import PromoCodes from './Component/PromoCodes'
import PaymentOption from './Component/PaymentOption'
import { mapGetters } from 'vuex';

export default {
	data(){
		return{
			stepOneFormValid: false,
			expansionPanel: [0]
		}
	},
	components:{
		shippingAddress:ShippingAddress,
		promoCodes:PromoCodes,
		paymentOption:PaymentOption
	},
	computed: {
		...mapGetters(["cart"]),
		panel: {
			get() {
				return this.expansionPanel;
			},
			set(val) {
				if(val.includes(0)){
					this.expansionPanel = [0];
					this.stepOneFormValid = false;
				}else if(val.includes(1) && this.expansionPanel != 1){
					this.expansionPanel = [1];
				}else if(val.includes(2)){
					this.expansionPanel = [2];
				}else{
					this.expansionPanel= [];
				}
			}
		}
	},
	methods: {
		enableStepOneForm(){
			this.stepOneFormValid = true;
			this.expansionPanel = [1];
		},
		changePanelValue(){
			this.expansionPanel = [2];
		}
	}
}
</script>
