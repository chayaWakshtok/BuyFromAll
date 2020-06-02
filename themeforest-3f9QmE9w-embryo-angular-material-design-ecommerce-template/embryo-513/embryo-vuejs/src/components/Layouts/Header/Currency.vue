<template>
	<div class="currency-menu">
		<v-menu transition="scale-transition" :nudge-width="70" light>
			<template v-slot:activator="{ on }">
				<v-toolbar-title v-on="on">
					<a heref="javascript:void(0)" class="white--text font-weight-regular">{{selectedCurrency.title}}</a>
					<v-icon dark>arrow_drop_down</v-icon>
				</v-toolbar-title>
			</template>
			<v-list class="py-0">
				<v-list-item v-for="(currency,key) in currencies" :key="key" @click="changeCurrency(currency)">
					<img :src="currency.img" class="mr-2" width="24" height="24">
					<span>{{currency.title}}</span>
				</v-list-item>
			</v-list>
		</v-menu>
	</div>
</template>

<script>
	import { mapGetters } from "vuex";

	export default {
		computed: {
			...mapGetters(["selectedCurrency", "currencies"])
		},
		methods: {
			changeCurrency(currency) {
				this.$store.dispatch("changeCurrency", currency);
			}
		}
	}
</script>