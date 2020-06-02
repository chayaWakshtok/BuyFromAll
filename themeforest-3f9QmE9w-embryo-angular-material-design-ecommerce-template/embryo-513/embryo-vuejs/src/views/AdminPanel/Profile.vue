<template>
   <div class="profile-wrapper emb-card pa-4">
      <h4>Profile Information</h4>
      <div class="pt-4">
         <div class="proflie-field mb-4" v-for="(info,key) in profileData" :key="key">
            <label>{{info.key}} :</label>
            <span>{{info.value}}</span>
         </div>         
         <v-btn :to="{name:'AdminEditProfileInfo', params: {title:'edit'},
               query: {type: 'info'}}"  class="accent mx-0"> Edit
         </v-btn>
      </div>
   </div>
</template>

<script>
export default {
   data(){
      return{
         profileData:[
            {
               key:"First Name",
               value:"John",
            },
            {
               key:"Last Name",
               value:"Doe"
            },
            {
               key:"Gender",
               value:"Female"
            },
            {
               key:"Date Of birth",
               value:"9th May 1995"
            },
            {
               key:"Mobile Number",
               value:"+123 456 789 123"
            },
            {
               key:"Location",
               value:"San Francisco"
            },
            {
               key:"E-mail id",
               value:"johnDoe@doe.com"
            }
         ]
      }
   }
}
</script>

