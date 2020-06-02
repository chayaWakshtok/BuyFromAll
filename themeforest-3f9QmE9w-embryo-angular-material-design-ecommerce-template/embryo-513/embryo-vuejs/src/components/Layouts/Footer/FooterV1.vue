<template>
	<div class="footerV1-wrap section-gap">
		<v-container grid-list-xl py-0>
			<div class="footer-top">
				<v-layout row wrap>
					<v-flex xs12 sm12 md4 lg5 xl5>
						<div class="about-wrap">
							<h6 class="white--text mb-6">{{title}}</h6>
							<span class="white--text">{{description}}</span>
						</div>
					</v-flex>
					<v-flex xs12 sm3 md2 lg2 xl2>
						<h6 class="white--text mb-4">About</h6>
						<div class="abt-menu">
							<ul class="list-unstyled pl-0">
								<li v-for="(list,key) in about"
									:key="key">
									<router-link :to="list.path">{{$t(list.menuItem)}}</router-link>
								</li>
							</ul>
						</div>
					</v-flex>
					<v-flex xs12 sm3 md2 lg2 xl2>
						<h6 class="white--text mb-4">Session</h6>
						<div class="features-menu">
							<ul class="list-unstyled pl-0">
								<li 
									v-for="(list,key) in session"
									:key="key"
								>
									<router-link :to="list.path">{{$t(list.menuItem)}}</router-link>
								</li>		
							</ul>
						</div>
					</v-flex>
					<v-flex xs12 sm3 md2 lg2 xl>
						<h6 class="white--text mb-4">Categories</h6>
						<div class="policy-menu">
							<ul class="list-unstyled pl-0">
								<li v-for="(list,key) in categories"
									:key="key">
									<router-link :to="list.path">{{$t(list.menuItem)}}</router-link>
								</li>
							</ul>
						</div>
					</v-flex>
					<v-flex xs12 sm3 md2 lg1 xl1>
						<div class="policy-menu">
							<h6 class="white--text mb-4">Social</h6>
							<ul class="list-unstyled pl-0">
								<li v-for="(list,key) in socialLinks"
									:key="key">
									<a :href="list.path">{{$t(list.menuItem)}}</a>
								</li>
							</ul>
						</div>
					</v-flex>
				</v-layout>
			</div>
			<hr>
			<div class="footer-bottom">
				<div class="footer-bottom-content px-3">
					<v-layout row wrap align-center justify-space-between>
						<v-flex xs12 sm12 md6 lg6 xl6 class="text-md-left text-center"> 
							<img :src="img" width="218" height="18"/>
						</v-flex>
						<v-flex xs12 sm12 md6 lg6 xl6 py-3 px-2>
							<div class="text-md-right text-center">
								<span class="white--text">{{copyrightText}}</span>
							</div>
						</v-flex>
					</v-layout>
				</div>
			</div>
		</v-container>
	</div>
</template>

<script>
import AppConfig from "Constants/AppConfig";

export default {
	props:['title','description','img'],
	data () {
		return{
			about:[
				{
					menuItem:"message.about",
					path:"/about"
				},
				{
					menuItem:"message.termAndCondition",
					path:"/term-condition"
				},
				{
					menuItem:"message.privacyPolicy",
					path:"/privacy-policy"
				},
				{
					menuItem:"message.faq",
					path:"/faq"
				},
				{
					menuItem:"message.contactUs",
					path:"/contact"
				},
			],
			session:[
				{
					menuItem:"message.signIn",
					path:"/session/signin"
				},
				{
					menuItem:"message.register",
					path:'/session/signup',
				},
				{
					menuItem:"message.forgotPassword",
					path:"/session/forgot-password",
				},
				{
					menuItem:"message.thankYou",
					path:"/session/thank-you"
				}
			],
			categories:[
				{
					menuItem:"message.men",
					path:"/products/men"
				},
				{
					menuItem:"message.women",
					path:"/products/women"
				},
				{
					menuItem:"message.accessories",
					path:"/products/accesories"
				},
				{
					menuItem:"message.gadgets",
					path:"/products/gadgets"
				}
			],
			socialLinks:[
				{
					menuItem:"message.facebook",
					path:"https://www.facebook.com/"
				},
				{
					menuItem:"message.twitter",
					path:"https://twitter.com/"
				},
				{
					menuItem:"message.youtube",
					path:"https://www.youtube.com/"
				},
				{
					menuItem:"message.googlePlus",
					path:"https://plus.google.com/discover"
				},

			],
			copyrightText: AppConfig.copyrightText
		}
	}
}
</script>

