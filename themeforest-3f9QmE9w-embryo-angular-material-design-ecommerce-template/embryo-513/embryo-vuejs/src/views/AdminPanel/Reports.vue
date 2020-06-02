<template>
   <div>
      <v-layout class="emb-card mb-6">
			<app-card 
				customClasses="pa-6"
            colClasses="xl12 lg12 md12 xs12 sm12"
            heading="Buy / Sell"
            :removePanel="true"
            :viewMore="true"
            :disableNotification="true"
            :settings="true"
            >
            <buy-or-sell></buy-or-sell>
         </app-card>
      </v-layout>
      <v-layout class="emb-card mb-6">
         <app-card 
				colClasses="xl12 lg12 md12 xs12 sm12"
				contentCustomClass="pa-6"
         >
         	<tabs-and-table ></tabs-and-table>
         </app-card>
      </v-layout>
   </div>
</template>

<script>
   import TabsAndTable from 'Components/Widgets/TabsAndTable'
   import BuyOrSell from "Components/Widgets/BuyOrSell";
   
   export default {
      components:{
         TabsAndTable,
         BuyOrSell
      },
   }
</script>