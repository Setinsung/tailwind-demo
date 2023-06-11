<template>
  <div id="postList">
    <div class="h-9 w-full leading-9 text-right bg-black">
      <div class="text-white">
        <span class="pr-2.5">登录</span>
        <span class="pr-2.5">注册</span>
      </div>
    </div>
    <div id="content" class="w-[98%] mx-auto">
      <div class="my-4 border border-ccc">
        <div class="h-9">
          123
        </div>
        <div class="text-center">
          <img src="https://img2.baidu.com/it/u=3220269019,3413898362&fm=253&fmt=auto&app=138&f=JPEG?w=1000&h=500" alt=""
            class="inline-block">
          <h2 class="text-primary text-2xl font-bold my-2.5">我是标题</h2>
        </div>
      </div>
      <div id="send-post" class="my-5">
        <el-button type="primary">发帖</el-button>
      </div>
      <div id="post-list" class="my-5 border border-ccc border-b-0">
        <table class="w-full m-auto border-collapse text-base">
          <thead>
            <tr>
              <td colspan="2" class="h-10 pl-4 border-b border-ccc bg-eee space-x-6 text-primary">
                <span>全部主题</span>
                <span>最新</span>
                <span>热门</span>
                <span>热帖</span>
                <span>精华</span>
              </td>
              <td class="h-10 border-b border-ccc bg-eee">作者</td>
              <td class="h-10 border-b border-ccc bg-eee">回复/查看</td>
              <td class="h-10 border-b border-ccc bg-eee">最后发表</td>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td class="w-[32px] h-10 border-b border-ccc text-center">
                <i class="el-icon-document text-xl text-honey-yellow"></i>
              </td>
              <td class="h-10 border-b border-ccc">
                <span class="px-2 text-primary">[帖子种类]</span>
                <router-link to="/postDetail">帖子标题</router-link>
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>Ace</p>
                <p class="text-999">2023-03-10 10:00</p>
              </td>
              <td class="w-[80px] h-10 border-b border-ccc">
                <p>996</p>
                <p class="text-999">1007</p>
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>admin</p>
                <p class="text-999">2023-03-10 10:01</p>
              </td>
            </tr>
            <tr>
              <td class="w-[32px] h-10 border-b border-ccc text-center">
                <i class="el-icon-document text-xl text-honey-yellow"></i>
              </td>
              <td class="h-10 border-b border-ccc">
                <span class="px-2 text-primary">[帖子种类]</span>帖子标题
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>Ace</p>
                <p class="text-999">2023-03-10 10:00</p>
              </td>
              <td class="w-[80px] h-10 border-b border-ccc">
                <p>996</p>
                <p class="text-999">1007</p>
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>admin</p>
                <p class="text-999">2023-03-10 10:01</p>
              </td>
            </tr>
            <tr>
              <td class="w-[32px] h-10 border-b border-ccc text-center">
                <i class="el-icon-document text-xl text-honey-yellow"></i>
              </td>
              <td class="h-10 border-b border-ccc">
                <span class="px-2 text-primary">[帖子种类]</span>帖子标题
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>Ace</p>
                <p class="text-999">2023-03-10 10:00</p>
              </td>
              <td class="w-[80px] h-10 border-b border-ccc">
                <p>996</p>
                <p class="text-999">1007</p>
              </td>
              <td class="w-[145px] h-10 border-b border-ccc">
                <p>admin</p>
                <p class="text-999">2023-03-10 10:01</p>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
      <div id="post-page" class="text-right mb-9">
        <el-pagination background layout="prev, pager, next" :page-size="30" :total="1000">
        </el-pagination>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  name: 'PostsView',
  components: {
  }
}
</script>

<style scoped lang="less">
</style>