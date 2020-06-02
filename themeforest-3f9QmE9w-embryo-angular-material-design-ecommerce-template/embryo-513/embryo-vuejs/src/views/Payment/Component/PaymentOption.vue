<template>
	<div>
		<v-expansion-panel-header class="primary"><h4 class="mx-2 mb-0 white--text">Payment Options</h4></v-expansion-panel-header>
		<v-expansion-panel-content>
			<div>
				<v-tabs light slider-color="primary" v-model="activePayment">
					<v-tab class="text-capitalize">Offer Code</v-tab>
					<v-tab class="text-capitalize">Credit/Debit/NetBanking</v-tab>
					<v-tab-item>
						<v-card flat>
							<v-card-text class="pa-0">
								<div class="header text-center bg-grey pt-12 pb-4">
									<div class="mb-6">
										<img  alt="discount" src="/static/images/card.png">
									</div>
									<h4 class="mb-12 font-weight-medium">Enter Card Details</h4>
								</div>
								<v-form class="form-wrapper pt-6 text-center py-12" ref="form" v-model="valid">
									<div class="layout row wrap">
										<v-flex xs12 sm12 md12 lg8 xl8>
											<div class="layout row wrap">
												<v-flex xs12 sm12 md6 lg10 xl10>
													<v-text-field class="mt-0 pt-0" :rules="inputRules.basictextRules" light label="Card Number" required></v-text-field>
												</v-flex>
												<v-flex xs12 sm12 md6 lg10 xl10>
													<v-text-field class="mt-0 pt-0" :rules="inputRules.basictextRules" light label="Name" required></v-text-field>
												</v-flex>
												<v-flex xs12 sm6 md6 lg3 xl3>
													<v-text-field class="mt-0 pt-0" :rules="inputRules.basictextRules" light label="CVV" required>
													</v-text-field>
												</v-flex>
												<v-flex xs12 sm6 md6 lg3 xl3>
													<v-text-field class="mt-0 pt-0" :rules="inputRules.basictextRules" light label="Expiry Date(01/10)" required></v-text-field>
												</v-flex>
												<v-flex xs12 sm12 md12 lg12 xl12>
													<div class="text-xl-left text-sm-left">
														<v-btn class="accent mr-3" @click="makePayment">Submit</v-btn>
														<v-btn>Clear</v-btn>
													</div>
												</v-flex>
											</div>
									</v-flex>
									<v-flex xs12 sm12 md12 lg3 xl2 hidden-md-and-down d-flex justify-center align-center card-visibility>
											<img src="/static/images/credit-card.png" slt="Credit card" width="128" height="128">
									</v-flex>
									</div>
								</v-form>
							</v-card-text>
						</v-card>
					</v-tab-item>
					<v-tab-item>
						<v-card flat>
							<v-card-text class="pa-0">
								<div class="header text-center bg-grey pt-12 pb-4">
									<div class="mb-6">
										<img alt="Bank" src="/static/images/online-shop.png">
									</div>
									<h4 class="mb-12 font-weight-medium">Select Bank For Net Banking</h4>
								</div>
								<v-divider class="mt-12 mb-2"></v-divider>
								<div class="text-center">
									<v-container grid-list-lg>
										<v-layout row wrap>
											<v-radio-group v-model="currentSelectedBank" :mandatory="false" row text-center>
												<v-radio v-for="bank in netbankingsMerchants" :key="bank.value" :value="bank.value" class="radio-img">
													<template slot="label">
														<img :src="bank.img" width="150" height="30"/>
													</template>
												</v-radio>
											</v-radio-group>
										</v-layout>
										<h6 class="text-left mb-0">All Banks</h6>
										<div class="layout ">
											<v-flex xs9 sm7 md5 lg5 xl5>
												<v-select :items="bankListing" class="mt-0 pt-0"></v-select>
											</v-flex>
										</div>
										<div class="text-left">
											<v-btn class="accent" @click="makePayment">Make Payment</v-btn>
										</div>
									</v-container>
								</div>
							</v-card-text>
						</v-card>
					</v-tab-item>
				</v-tabs>
			</div>
		</v-expansion-panel-content>
	</div>	
</template>

<script>
	import { mapGetters } from 'vuex';
   export default{
		computed: {
			...mapGetters(["stepOneFormValid","cart"])
		},
      data () {
	   	return{
            activePayment: null,
				valid: false,
				inputRules: {
					basictextRules: [v => !!v || 'This field should not be empty.'],
				},
            val: '',
            currentSelectedBank: 'bank-1',
            netbankingsMerchants: [
               {
                  value: 'bank-1',
                  img: '/static/images/topbrands/client-logo-1.png'
               },
               {
                  value: 'bank-2',
                  img: '/static/images/topbrands/client-logo-2.png'
               },
               {
                  value: 'bank-3',
                  img: '/static/images/topbrands/client-logo-3.png'
               },
               {
                  value: 'bank-4',
                  img: '/static/images/topbrands/client-logo-4.png'
               },
               {
                  value: 'bank-5',
                  img: '/static/images/topbrands/client-logo-5	.png'
               },
            ],
            bankListing:['Option1','Option2','Option3','Option4'],
         }
		},
		methods:{
			/**
			 * This Function is to make Payment
			*/
			makePayment(){
            this.$refs.form.validate()
            if(this.valid){
				   this.$store.dispatch("makePayment", this.cart);
            }
			}
		}
   }
</script>