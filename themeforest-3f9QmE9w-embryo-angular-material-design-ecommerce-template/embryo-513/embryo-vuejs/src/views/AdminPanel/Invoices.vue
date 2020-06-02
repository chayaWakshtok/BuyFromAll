<template>
   <div>
     <h4 class="mb-6">Invoice List</h4>
		<div class="pa-4 pt-0 emb-card mb-6">
			<v-row >
				<v-col cols="12"
				sm="8" md="5" lg="5">
					<v-text-field v-model="search" label="Search" single-line hide-details>
					</v-text-field>
				</v-col>
			</v-row>
		</div>
       <div class="emb-card pa-4">
         <invoice :search="search"></invoice>
       </div>
   </div>
</template>

<script>
   import Invoice from 'Components/Widgets/Invoice.vue'

   export default {
      data (){
			return{
            search:''
			}
      },
      components:{
         Invoice
      }
   }
</script>