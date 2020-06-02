<template>
	<div>
		<div class="main">
			<div class="banner-wrap">
				<emb-home-main-banner-v2 :data="homeBannerV2Data"></emb-home-main-banner-v2>
			</div>
			<card-items :data="cardData"></card-items>
			<lightening-deals :data="LighteningDealsData" secTitle="Lightening Deals"></lightening-deals>
			<top-products :data="topProductData" secTitle="Top Products"></top-products>
			<div class="top-brands-wrap-v1">
				<emb-shop-card	 class="pt-0" secTitle="Top Brands"	:data="topBrandsData"></emb-shop-card>
			</div>
			<div class="section-gap pb-0">
				<subscribe-v2
					heading="Subscribe our Newsletter"
					description="Stay up to date with our latest new and products"
				>
				</subscribe-v2>
			</div>
		</div>
	</div>
</template>

<script>
// layout components
import HomeMainBannerV2 from "Components/Layouts/Banner/HomeMainBannerV2";
// data
import homeBannerV2Data from "Assets/data/homeBannerV2Data";
import cardData from "Assets/data/cardData";
import LighteningDealsData from "Assets/data/lighteningDealsData";
import topProductData from "Assets/data/topProductData";
import topBrandsData from "Assets/data/topBrandsData";

// widgets
import CardItems from "Components/Widgets/CardItems";
import LighteningDeals from "Components/Widgets/LighteningDeals";
import TopProducts from "Components/Widgets/TopProducts";
import SubscribeV2 from "Components/Widgets/SubscribeV2";
import ShopCard from "Components/Widgets/ShopCard";

import {mapGetters} from "vuex";

export default {
	computed: {
		...mapGetters(["selectedProduct"]),
	},
   components: {
      embHomeMainBannerV2: HomeMainBannerV2,
      cardItems:CardItems,
      lighteningDeals:LighteningDeals,
      topProducts:TopProducts,
      embShopCard: ShopCard,
      subscribeV2:SubscribeV2,

   },
   data() {
		return {
         homeBannerV2Data,
         cardData,
         LighteningDealsData,
         topProductData,
         topBrandsData
      }
   }     
}
</script>
