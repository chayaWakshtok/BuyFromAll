<template>
  <div>
    <v-expansion-panel-header class="primary"><h4 class="mx-2 mb-0 white--text">Unlock Offers or Apply Promo Codes</h4></v-expansion-panel-header>
    <v-expansion-panel-content>
          <div>
            <v-tabs light slider-color="primary" v-model="active">
                <v-tab class="text-capitalize">Offer Code </v-tab>
                <v-tab class="text-capitalize">Credit/Debit/NetBanking</v-tab>
                <v-tab-item>
                  <v-card flat>
                      <v-card-text class="pa-0">
                        <div class="header  text-center bg-grey pt-12 pb-4">
                            <div class="mb-6">
                              <img  alt="discount" src="/static/images/discount.png">
                            </div>
                            <h4 class="mb-12 font-weight-medium">Apply for Embryo offer/Discount</h4>
                        </div>
                        <div class="form-wrapper py-12 text-center">
                            <div class="d-inline-flex">
                              <v-text-field
                                  class="mt-0 pt-0"
                                  light
                                  label="Enter Code"
                                  required
                              >
                              </v-text-field>
                    				<v-btn icon @click="enterCouponCode"><v-icon>send</v-icon></v-btn>
                            </div>
                            <p class="mb-0 grey--text">*Only Valid coupon or offer code is acceptable.</p>
                            <p class="grey--text"> To know your coupon valid or not click <a href="javascript:void(0)">Here</a></p>
                        </div>
                      </v-card-text>
                  </v-card>
                </v-tab-item>
                <v-tab-item>
                  <v-card flat>
                      <v-card-text class="pa-0">
                        <div class="header  text-center grey lighten-4 pt-12 pb-4">
                            <div class="mb-6">
                              <img  alt="Card" src="/static/images/card.png">
                            </div>
                            <h4 class="mb-12 font-weight-medium">Apply for Card offers</h4>
                        </div>
                        <v-divider class="my-12"></v-divider>
                        <v-radio-group v-model="val" row class="main-divi text-center d-block">
                            <v-radio 
                              v-for="item in cardItem"
                              :key="item.offer"
                              :value="item.offer"
                            >
                              <label slot="label">
                                  <a href="javascript:void(0)">
                                    <span class="black--text font-weight-medium">{{ item.offer }}</span>
                                    <br>
                                    <span class="grey--text text-center">{{ item.type}} </span>
                                  </a>
                              </label>
                            </v-radio>
                        </v-radio-group>
                        <v-divider class="my-12"></v-divider>
                        <h4 class="text-center">Select Offer</h4>
                        <v-layout row wrap align-center justify-center>
                            <v-flex xs8 sm6 md3 lg2 xl2 mb-4>
                              <v-select :items="offers"></v-select>
                            </v-flex>
                        </v-layout>
                      </v-card-text>
                  </v-card>
                </v-tab-item>
            </v-tabs>
          </div>
      </v-expansion-panel-content>
   </div> 
</template>

<script>
	import { mapGetters } from "vuex";
   export default {
		props: ["changePanel"],
		computed: {
			...mapGetters(["couponCode"])
		},
      data () {
	   	return{
            offers:["Flat 50%", "Flat 55.4%"],
            val: "",
            cardItem:[
               {
                  offer:"Visa Mega Shopping Offer",
                  type:"Debit Card"
               },
               {
                  offer:"American Express 20% Flat",
                  type:"Credit Card"
               },
               {
                  offer:"BOA Buy 1 Get One Offer",
                  type:"Debit Card"
               },
               {
                  offer:"Mastercard Elite Card",
                  type:"Credit Card"
               },
               {
                  offer:"Mastercard Card",
                  type:"Credit Card"
               }
				],
				active: null
		   }
		},
		methods:{
			/**
		 * This function sets the value into store for CouponCode
		**/
			enterCouponCode(){
				this.$emit('changePanel');
				this.$store.dispatch("enterCouponCode", this.couponCode);
			}
		}
   }
</script>