<template>
  <div id="app">
    <nav class="nav">
      <router-link to="/posts">Posts</router-link> |
      <router-link to="/postDetail">PostDetail</router-link>
    </nav>
    <router-view/>
  </div>
</template>
<script>

export default {
  name: 'App',
  components: {
  }
}
</script>

<style scoped lang="less">
.nav {
  position: fixed;
  top: 0;
  right: 0;
}
</style>
