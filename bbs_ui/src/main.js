import Vue from 'vue'
import App from './App.vue'
import router from './router'
import "./css/tailwindcss.css"
import ElementUI from 'element-ui';
import { ElementTiptapPlugin } from 'element-tiptap';
import 'element-ui/lib/theme-chalk/index.css';
import 'element-tiptap/lib/index.css';
import './global.less'
Vue.config.productionTip = false

Vue.use(ElementUI);
Vue.use(ElementTiptapPlugin, {
  /* plugin options */
  lang: 'zh',
});
new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
