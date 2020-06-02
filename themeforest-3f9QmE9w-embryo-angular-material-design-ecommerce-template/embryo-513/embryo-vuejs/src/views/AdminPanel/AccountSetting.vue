<template>
	<div class="emb-card pa-4 admin-profile-wrap">
		<div class="thumb-wrap thumb-width" for="upload" >
			<v-img src="/static/images/user.png" />
			<div class="edit-btn d-flex justify-center align-center">
				<v-icon dark>edit</v-icon>
			</div>
			<input type="file" id="upload" accept="image/*" class="upload-img">
		</div>
		<div class="mb-8">
				<h5>Notifications</h5>
				<v-checkbox label="Enable Notifications"></v-checkbox>
				<v-checkbox label="Show Desktop Notifications"></v-checkbox>
				<v-checkbox label="Get e-mail notification for my own activity"></v-checkbox>
				<v-checkbox label="Get e-mail notification for request and reviews"></v-checkbox>
		</div>
		<div class="mb-6">
				<h5>Deactivate your account</h5>
				<p>Reason for leaving :</p>
				<v-radio-group v-model="radios" :mandatory="false">
					<v-radio label="This is temporary. I'll be back." value="radio1"></v-radio>
					<v-radio label="My account was hacked." value="radio2"></v-radio>
					<v-radio label="I have a privacy concern." value="radio3"></v-radio>
					<v-radio label="Other" value="radio4"></v-radio>
				</v-radio-group>
		</div>
		<div class="d-sm-inline-flex align-items-center mb-6">
				<p class="mr-3 pt-4 mb-0">If other then please explain further : </p>
				<v-textarea name="input-7-4" class="account-text mt-0 pt-0" rows="1"></v-textarea>
		</div>
		<div>
			<v-btn color="error" slot="activator" @click="deactivateAccount()">
				Deactivate Account
			</v-btn>
		</div>
		<emb-delete-confirmation-2 ref="deleteConfirmationDialog" messageTitle="Are You Sure You Want To Delete?"
			messageDescription="Are you sure you want to delete this account permanently?" @onConfirm="onDeactivateAccount"
			btn1="Cancel" btn2="Yes">
		</emb-delete-confirmation-2>
	</div>
</template>

<script>
export default {
  data() {
    return {
      radios: "radio1",
      checkbox: false
    };
  },
  methods: {
    deactivateAccount() {
      this.$refs.deleteConfirmationDialog.openDialog();
    },
    onDeactivateAccount() {
      this.$refs.deleteConfirmationDialog.close();
    }
  }
};
</script>
<style>
.thumb-width {
  width: 70px !important ;
}
.account-text .v-text-field__details {
  display: none;
}
</style>
