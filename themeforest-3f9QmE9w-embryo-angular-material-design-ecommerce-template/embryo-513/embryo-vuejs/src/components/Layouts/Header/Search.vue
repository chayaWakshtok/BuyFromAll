<template>
   <div>
      <div class="search-box">
        <v-btn class="d-inline-block" fab dark v-if="isHidden"	color="accent" @click="isHidden = false">
            <v-icon>search</v-icon>
         </v-btn>
      </div>
      <div  class="search-form"  v-if="!isHidden">
        <div class="form">
          <input type="text" placeholder="Search Here">
            <v-btn class="close-btn white" @click="isHidden = !isHidden">
              <v-icon>close</v-icon>
            </v-btn>
         </div>
      </div>
   </div>
</template>

<script>
   export default {
      data (){
         return{
            isHidden: true,
         }
      }
   }
</script>
