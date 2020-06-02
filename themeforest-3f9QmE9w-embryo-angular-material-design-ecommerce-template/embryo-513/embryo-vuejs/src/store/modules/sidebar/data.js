/* eslint-disable */
// Sidebar Routers
export const menus = [
   {
      path: '',
      name: "message.home",
		icon: "home",
		type: "sub_menu",
      children: [
			{
				name: "message.homeOne",
				children_menus:null,
            path: "/home"
			},
			{
				name: "message.homeTwo",
				children_menus:null,
            path: "/home-two"
         },
         {
				name: "message.homeThree",
				children_menus:null,
            path: "/home-three"
			},
		]
   },
   {
      path:'',
      name: "message.shop",
      icon: "pages",
      type: "sub_menu",
      children: [
			{
				name: "message.productDetails",
				children_menus:null,
            path: "/products/men/102"
			},
			{
				name: "message.cart",
				children_menus:null,
            path: "/cart"
			},
			{
				name: "message.checkout",
				children_menus:null,
            path: "/checkout",
			},
			{
				name: "message.payment",
				children_menus:null,
            path: "/checkout/payment"
         }
      ]
	},
   {
      path: '/products/accessories',
      name:"message.accessories",
      icon: 'party_mode',
      children: null
   },
   {
      path: '',
      name:"message.categories",
      icon: 'party_mode',
      type: 'mega_menu',
      children: {
         'message.men': [
            {
               path: 'T-shirt',
               children_menus:null,
               name: 'message.tShirt'
            },
            {
               path: 'Shirt',
               children_menus:null,
               name: 'message.shirt'
            },
            {
               path: 'Jeans',
               children_menus:null,
               name: 'message.jean'
            },
            {
               path: 'Jackets',
               children_menus:null,
               name: 'message.jackets'
            },
         ],
         'message.women': [
            {
               path: 'Dresses',
               children_menus:null,
               name: 'message.dresses'
            },
            {
               path: 'Jean',
               children_menus:null,
               name: 'message.jean'
            },
            {
               path: 'Shirt',
               children_menus:null,
               name: 'message.shirt'
            },
            {
               path: 'Jackets',
               children_menus:null,
               name: 'message.jackets'
            },
         ],
         'message.gadgets': [
            {
               path: 'Headphone',
               children_menus:null,
               name: 'message.headphone'
            },
            {
               path: 'Smartphone',
               children_menus:null,
               name: 'message.smartphone'
            },
            {
               path: 'Watch',
               children_menus:null,
               name: 'message.watch'
            },
            {
               path: 'Speaker',
               children_menus:null,
               name: 'message.speaker'
            },
         ],
         'message.accessories': [
            {
					path: 'Laptop',
					children_menus:null,
               name: 'message.laptopAccessories'
            },
            {
               path: 'Belts',
               children_menus:null,
               name: 'message.belts'
            },
            {
               path: 'Jewellery',
               children_menus:null,
               name: 'message.jewellery'
            },
            {
               path: 'Purse',
               children_menus:null,
               name: 'message.purse'
            }
         ]
      }
   },
   {
      path: "",
      name: "message.pages",
      icon: "pages",
      type: "sub_menu",
      children: [
         {
            name: "message.about",
            children_menus:null,
            path: "/about"
         },
         {
            name: 'message.termAndCondition',
            children_menus:null,
            path: '/term-condition'
         },
         {
            name: 'message.privacyPolicy',
            children_menus:null,
            path: '/privacy-policy'
         },
         {
            name: 'message.blogDetail',
            children_menus:null,
            path: '/blog-detail/1'
         },
         {
            name: 'message.faq',
            children_menus:null,
            path: '/faq'
         },
         {
            name: 'message.404Page',
            children_menus:null,
            path: 'not-found'
			},
			{
            name: 'message.userProfile',
            children_menus:null,
            path: '/account/profile'
         },
         {
            name: 'message.session',
            path: '',
				icon: 'supervised_user_circle',
				type: "sub_menu",
				children_menus:[
					{
						name: 'message.signIn',
						path: '/session/signin'
					},
					{
						name: 'message.register',
						path: '/session/signup'
					},
					{
						name: 'message.forgotPassword',
						path: '/session/forgot-password'
					},
					{
						name: 'message.thankYou',
						path: '/session/thank-you'
					},
				]
         },
      ]
   },
   {
      path: '/contact',
      name:"message.contactUs",
      icon: 'perm_contact_calendar',
      children: null
   },
   {
      path: '/admin-panel/reports',
      name:"message.adminPanel",
      icon: 'perm_identity',
      children:null
   },
]


export const adminPanelMenus = [
	{
      path: '/admin-panel/reports',
      name:"message.reports",
      icon: 'poll',
      children:null,
		active: true
   },
   {
      path: '/admin-panel/invoices',
      name:"message.invoices",
      icon: 'recent_actors',
      children:null,
		active: false
   },
   {
      path: '',
      name:"message.products",
      icon: 'shopping_cart',
		active: false,
      children: [
			{
				name: "message.products",
				path: "/admin-panel/products"
			},
			{
				name: "message.productAdd",
				path: "/admin-panel/product-add"
         },
      ]
      
   },
   {
      path: '/admin-panel/account/profile',
      name:"message.profile",
      icon: 'account_circle',
		active: false,
      children: null
   },
   {
      path: '/home',
      name:"message.goToSite",
      icon: 'home',
		active: false,
      children: null
   },
]