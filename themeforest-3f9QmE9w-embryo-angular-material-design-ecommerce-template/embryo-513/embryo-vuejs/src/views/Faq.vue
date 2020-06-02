<template>
   <div class="emb-faq-wrap">
		<emb-page-title
			heading="Frequently Asked Question"
			subHeading="We explained the basics question in this section."
		>
		</emb-page-title>
		<div class="emb-faq-content section-gap pb-0">
         <div class="container">
            <div class="faq">
               <div class="sec-title mb-12">
						<div class="layout align-start">
							<h2 class="mb-6">Get Instant answers for most common questions</h2>
						</div>
						<p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Magni, aspernatur minus voluptatibus quaerat officiis, incidunt maiores, tempora nam eaque ab consequatur tenetur explicabo voluptatem vel voluptatum perspiciatis accusantium. Illum, nemo?</p>
               </div>
                <div class="section-gap pt-4">
						<v-expansion-panels>
							<v-expansion-panel
								v-for="(question,key) in faq"
								:key="key" 
							>	
								<v-expansion-panel-header>
									<h5 class="mb-0">{{question.ques}}</h5>
								</v-expansion-panel-header>
								<v-expansion-panel-content>
									{{question.ans}}
								</v-expansion-panel-content>
							</v-expansion-panel>
						 </v-expansion-panels>
               </div>
            </div>
         </div>
         <div class="subscribe-block subscribe-bg section-gap text-center">
            <div class="container pt-0">
               <v-layout row warp align-center justify-center>
                  <v-flex sm12 xl6 lg6 md6>
                     <h2 class="font-bold white--text mb-6"> Did not get your answer here?</h2>
                     <h6 class="white--text mb-6"> If your are unable to get the answers then feel free to contact us by
                        submit a support request. We will very happy to listen from you.
                     </h6>
                     <v-btn class="accent" large to="/contact">
                        Submit Request
                     </v-btn>
                  </v-flex>
               </v-layout>
            </div>
         </div>
      </div>
   </div>
</template>

<script>
import api from "Api";
export default {
  data() {
    return {
      faq: []
    };
  },
  mounted() {
    this.getFaq();
  },
  methods: {
    getFaq() {
      api
        .get("faq.json")
        .then(response => {
          this.faq = response.data.faqs;
        })
        .catch(error => {
          console.log(error);
        });
    }
  }
};
</script>