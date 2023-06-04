import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  // {
  //   path: "/",
  //   redirect: {
  //     name: "posts",
  //   },
  // },
  {
    path: '/posts',
    name: 'posts',
    component: () => import(/* webpackChunkName: "about" */ '../views/PostsView.vue')
  },
  {
    path: '/postDetail',
    name: 'postDetail',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/PostDetailView.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
