<template>
   <div class="emb-blogDetail-wrap" v-if="selectedBlog != null" >
		<div class="blog-img-wrapper relative" :style="{'background-image': ' url('+ selectedBlog.origanalThumb+ ')'}">
			<div class="center-holder">
				<div class="container">
					<v-layout row wrap align-center justify-center ma-0>
						<v-flex sm12 xs12 md8 lg7 xl7 pa-0>
							<h5 class="mb-6">
								<i class="material-icons">trending_up</i> 
								Featured post.
							</h5>
								<h2 class="mb-6">{{selectedBlog.subtitle}}</h2>
								<div class="blog-meta mb-4">
									<a class="mr-4" href="javascript:void(0);">
										<i class="material-icons">account_circle</i>
										<span class="font-weight-regular">
											{{selectedBlog.authorName}}
										</span>
									</a>
									<a href="javascript:void(0);">
										<i class="material-icons">date_range</i>
										<span class="font-weight-regular">{{selectedBlog.date}}</span>
									</a>
								</div>
						</v-flex>
					</v-layout>
				</div>
			</div>
		</div>
		<div class="inner-container bg-white">
         <v-container grid-list-xl pb-0>
				<div class="blog-detail section-gap">
					<v-layout row wrap align-center justify-center>
						<v-flex xs12 sm12 md10 lg7 xl7>
							<div class="blog-content mb-12"  v-html="selectedBlog.blogDesc">
							</div>
							<div class="tags-social-block mb-6">
								<div class="d-sm-flex align-center justify-space-between">
									<div class="mb-sm-0 mb-6">
										<v-chip color="accent" text-color="white">
											Shopping
										</v-chip>
										<v-chip color="accent" text-color="white">
											Online
										</v-chip>
									</div>
									<div>
										<emb-social-share></emb-social-share>
									</div>
								</div>
							</div>
							<div class="blog-links  grey lighten-3 pa-6">
								<div class="d-flex align-center justify-space-between " >
									<div class="previous-blog">
										<v-btn class="accent">Prev</v-btn>
									</div>
									<div class="next-blog ">
										<v-btn class="accent">Next</v-btn>
									</div>
								</div>
							</div>
							<div class="author-section pt-6 pb-2">
								<div class="sec-title">
									<h3 class="mb-0">About the Author</h3>
								</div>
								<v-layout row wrap align-center v-if="selectedBlog != null">
									<v-flex sm3 md2 lg2 xl2 mb-3>
										<img class="br-100" alt="author detail"  :src="selectedBlog.authorImg" width='200' height='200'>
									</v-flex>
									<v-flex sm9 md8 lg10 xl10 mb-3>
										<h4>{{selectedBlog.authorName}}</h4>
										<p>{{selectedBlog.authorDesc}}</p>
									</v-flex>
								</v-layout>
								<v-divider class="my-6"></v-divider>
							</div>
							<div class="blog-comment-section mb-2">
								<div class="sec-title">
									<h3 class="mb-0">Comments(3)</h3>
								</div>
								<!-- <ul class="comment-list"> -->								
								<ul class="comment-list">
									<template v-for="(comments,key) in CommentsList">
										<li class="layout comment-item row wrap  align-center justify-between" 									
											:key='key'
											v-if="comments.subComment"
										>
											<v-flex sm2 md2 lg2 xl2>
												<img class="br-50" :src="comments.img" alt="user" width="100" height="100">
											</v-flex>
											<v-flex sm10 md10 lg10 xl10>
												<h5>{{comments.username}}</h5>
												<p>{{comments.comment}}</p>
												<div class="d-flex justify-space-between">
													<div>
														<a href="javascript:void(0)" class="primary--text font-weight-bold">Reply</a>
													</div>
													<div class="primary--text font-weight-bold comment-date">
														{{comments.date}}
													</div>
												</div>
											</v-flex>
												<ul class="sub-comment comment-list">
													<li v-for="(comments,i) in comments.subComment" 
														:key="i"
														class="layout comment-item row wrap  align-center justify-between" 
														>
														<v-flex sm2 md2 lg2 xl2>
															<img class="br-50" :src="comments.img" alt="user" width="100" height="100">
														</v-flex>
														<v-flex sm10 md10 lg10 xl10>
															<h5>{{comments.username}}</h5>
															<p>{{comments.comment}}</p>
															<div class="d-flex justify-space-between">
																<div>
																	<a href="javascript:void(0)" class="primary--text font-weight-bold">Reply</a>
																</div>
																<div class="primary--text font-weight-bold comment-date">
																	{{comments.date}}
																</div>
															</div>
														</v-flex>	

													</li>
												</ul>
										</li>
										<li v-else :key='key' class="layout comment-item row wrap  align-center justify-between">
											<v-flex sm2 md2 lg2 xl2>
												<img class="br-50" :src="comments.img" alt="user" width="100" height="100">
											</v-flex>
											<v-flex sm10 md10 lg10 xl10>
												<h5>{{comments.username}}</h5>
												<p>{{comments.comment}}</p>
												<div class="d-flex justify-space-between">
													<div>
														<a href="javascript:void(0)" class="primary--text font-weight-bold">Reply</a>
													</div>
													<div class="primary--text font-weight-bold comment-date">
														{{comments.date}}
													</div>
												</div>
											</v-flex>
										</li>
									</template>
								</ul>
							</div>
							<div class="leave-commet pt-6">
								<div class="sec-title mb-6">
									<h3 class="mb-0">Leave Comments</h3>
								</div>
								<v-layout row wrap>
									<v-flex sm12 md12 lg12 xl12 py-0>
										<v-text-field type='text' class="mt-0" placeholder="First Name"></v-text-field>
										<v-text-field type='text' placeholder="Last Name"></v-text-field>
										<v-text-field type='email' placeholder="Email"></v-text-field>
										<v-textarea placeholder="Leave a Message" rows="2"></v-textarea>
									</v-flex>
								</v-layout>
								<v-btn class="accent mt-6 mx-0" large>Send Message</v-btn>	
							</div>
						</v-flex>
					</v-layout>
				</div>
         </v-container>
      </div>
   </div>
</template>

<script>
import { mapGetters } from "vuex";
import CommentsList from "Assets/data/comments";
export default {
  mounted() {
    if (this.blogData.length > 0) {
      for (var i = 0; i < this.blogData.length; i++) {
        if (this.$route.params.id == this.blogData[i].id) {
          this.selectedBlog = this.blogData[i];
        }
      }
    }
  },
  computed: {
    ...mapGetters(["blogData"])
  },
  data() {
    return {
      CommentsList,
      selectedBlog: null
    };
  }
};
</script>
