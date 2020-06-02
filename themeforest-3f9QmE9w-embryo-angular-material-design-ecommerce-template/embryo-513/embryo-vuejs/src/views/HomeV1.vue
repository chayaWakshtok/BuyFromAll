<template>
	<div>
		<div class="main">
			<div class="banner">
				<v-container grid-list-xl>
					<v-layout row wrap>
						<v-flex xs12 sm12 md12 lg8 xl8>
							<emb-home-main-banner
								:data="homeBannerData"
							>
							</emb-home-main-banner>
						</v-flex>
						<v-flex xs12 sm12 md12 lg4 xl4>
							<v-layout row wrap text-center mx-0>
								<v-flex xs12 sm6 md6 lg12 xl12 px-0>
									<emb-aside-banner-v1 
										img="/static/images/aside-1.jpg"
									>
									</emb-aside-banner-v1>
								</v-flex>
								<v-flex xs12 sm6 md6 lg12 xl12 px-0>
									<emb-aside-banner-v2 
										img="/static/images/aside-2.jpg"
									>
									</emb-aside-banner-v2>
								</v-flex>
							</v-layout>
						</v-flex>
					</v-layout>
				</v-container>
			</div>
			<emb-features
				:data="featuresData"
			>
			</emb-features>
			<emb-feature-product
				secTitle="Featured Products"
				:data="featureProductData"
			>
			</emb-feature-product>
			<emb-day-deal
				:data="dayDealData"
			>
			</emb-day-deal>
			<emb-detail-offer></emb-detail-offer>
			<emb-feature-product
				secTitle="New Arrivals"
				:data="latestArrivalData"
			>
			</emb-feature-product>
			<embTestimonial
				secTitle="Customer Reviews"
				:data="TestimonialData"
			>
			</embTestimonial>
			<emb-blog
				secTitle="Latest From Blogs"
				:data="blogData"
			>	
			</emb-blog>
			<emb-subscribe
				heading="Subscribe our Newsletter"
				description="Stay up to date with our latest new and products">
			</emb-subscribe>
			<emb-shop-card
				secTitle="Shop By Brands"
				:data="shopCard"
			>
			</emb-shop-card>
		</div>
	</div>
</template>
<script>
// layout components
import HomeMainBanner from "Components/Layouts/Banner/HomeMainBanner";
import AsideBannerV1 from "Components/Layouts/Banner/AsideBannerV1";
import AsideBannerV2 from "Components/Layouts/Banner/AsideBannerV2";

// widgets
import Features from "Components/Widgets/Feature";
import FeatureProduct from "Components/Widgets/FeatureProduct";
import DayDeal from "Components/Widgets/DayDeal";
import DetailOffer from "Components/Widgets/DetailOffer";
import Testimonial from "Components/Widgets/Testimonial";
import Blog from "Components/Widgets/Blog";
import ShopCard from "Components/Widgets/ShopCard";
import Subscribe from "Components/Widgets/Subscribe";

// data
import homeBannerData from "Assets/data/homeBannerData";
import featuresData from "Assets/data/featuresData";
import featureProductData from "Assets/data/featureProductData";
import dayDealData from "Assets/data/dayDealData";
import latestArrivalData from "Assets/data/latestArrivalData";
import TestimonialData from "Assets/data/TestimonialData";
import shopCard from "Assets/data/shopCard";

import api from "Api";

export default {
  components: {
    embHomeMainBanner: HomeMainBanner,
    embAsideBannerV1: AsideBannerV1,
    embAsideBannerV2: AsideBannerV2,
    embFeatures: Features,
    embFeatureProduct: FeatureProduct,
    embDayDeal: DayDeal,
    embDetailOffer: DetailOffer,
    embTestimonial: Testimonial,
    embBlog: Blog,
    embSubscribe: Subscribe,
    embShopCard: ShopCard
  },
  data() {
    return {
      homeBannerData,
      featuresData,
      featureProductData,
      dayDealData,
      latestArrivalData,
      TestimonialData,
      shopCard,
      blogData: null
    };
  },
  mounted() {
    this.getBlogData();
  },
  methods: {
    getBlogData() {
      api
        .get("blogs.json")
        .then(response => {
          this.blogData = response.data;
        })
        .catch(error => {
          console.log(error);
        });
    }
  }
};
</script>