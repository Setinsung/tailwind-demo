<template>
  <div id="postDetail" class="px-4">
    <div id="send-pad" class="h-14 mt-9">
      <el-button type="primary" size="small">回帖</el-button>
    </div>
    <div id="reply-content">
      <div id="post-title" class="flex bg-blue-post h-10 text-sm leading-9 border-b-[6px] border-blue-post-line">
        <div id="post-title-left" class="w-52 px-2">
          查看: 996 | 回复: 1007
        </div>
        <div id="post-title-right">
          帖子标题
        </div>
      </div>
      <ul>
        <li>
          <div id="content-item" class="flex border-b-[6px] border-blue-post-line">
            <div id="content-item-left" class="w-52 bg-blue-post">
              <div id="user-no" class="h-9 leading-9 pl-2 border-b border-dashed border-ccc">
                185986111
              </div>
              <div id="user-info" class="py-4 text-center text-sm">
                <img
                  src="https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimg9.doubanio.com%2Fview%2Fgroup_topic%2Fl%2Fpublic%2Fp515054775.jpg&refer=http%3A%2F%2Fimg9.doubanio.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1688468092&t=a73b384ce5ce4673f2b8b3911f61148c"
                  class="inline-block w-32 border-[6px] border-white">
                <p class="text-left pl-10 pt-2">admin</p>
                <p class="text-left pl-10 pt-2">等级: 16</p>
              </div>
            </div>
            <div id="content-item-right" class="flex-1 flex flex-col min-h-[252px] text-sm bg-white">
              <div id="send-time" class="h-9 leading-9 pl-1.5 border-b border-dashed border-ccc">
                发表于 2021-3-19 23:40
              </div>
              <div id="send-content" class="flex-1 p-1.5">
                这是内容
              </div>
              <div id="send-opn" class="h-9 leading-9 pl-1.5 space-x-4 border-t border-dashed border-ccc">
                <span>回复</span>
                <span>顶(1)</span>
                <span>踩(0)</span>
              </div>
            </div>
          </div>
        </li>
        <li>
          <div id="content-item" class="flex border-b-[6px] border-blue-post-line">
            <div id="content-item-left" class="w-52 bg-blue-post">
              <div id="user-no" class="h-9 leading-9 pl-2 border-b border-dashed border-ccc">
                185986111
              </div>
              <div id="user-info" class="py-4 text-center text-sm">
                <img
                  src="https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimg9.doubanio.com%2Fview%2Fgroup_topic%2Fl%2Fpublic%2Fp515054775.jpg&refer=http%3A%2F%2Fimg9.doubanio.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1688468092&t=a73b384ce5ce4673f2b8b3911f61148c"
                  class="inline-block w-32 border-[6px] border-white">
                <p class="text-left pl-10 pt-2">admin</p>
                <p class="text-left pl-10 pt-2">等级: 16</p>
              </div>
            </div>
            <div id="content-item-right" class="flex-1 flex flex-col min-h-[252px] text-sm bg-white">
              <div id="send-time" class="h-9 leading-9 pl-1.5 border-b border-dashed border-ccc">
                发表于 2021-3-19 23:40
              </div>
              <div id="send-content" class="flex-1 p-1.5">
                这是内容
              </div>
              <div id="send-opn" class="h-9 leading-9 pl-1.5 space-x-4 border-t border-dashed border-ccc">
                <span>回复</span>
                <span>顶(1)</span>
                <span>踩(0)</span>
              </div>
            </div>
          </div>
        </li>
        <li>
          <div id="content-item" class="flex border-b-[6px] border-blue-post-line">
            <div id="content-item-left" class="w-52 bg-blue-post">
              <div id="user-no" class="h-9 leading-9 pl-2 border-b border-dashed border-ccc">
                185986111
              </div>
              <div id="user-info" class="py-4 text-center text-sm">
                <img
                  src="https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fimg9.doubanio.com%2Fview%2Fgroup_topic%2Fl%2Fpublic%2Fp515054775.jpg&refer=http%3A%2F%2Fimg9.doubanio.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1688468092&t=a73b384ce5ce4673f2b8b3911f61148c"
                  class="inline-block w-32 border-[6px] border-white">
                <p class="text-left pl-10 pt-2">admin</p>
                <p class="text-left pl-10 pt-2">等级: 16</p>
              </div>
            </div>
            <div id="content-item-right" class="flex-1 flex flex-col min-h-[252px] text-sm bg-white">
              <div id="send-time" class="h-9 leading-9 pl-1.5 border-b border-dashed border-ccc">
                发表于 2021-3-19 23:40
              </div>
              <div id="send-content" class="flex-1 p-1.5">
                这是内容
              </div>
              <div id="send-opn" class="h-9 leading-9 pl-1.5 space-x-4 border-t border-dashed border-ccc">
                <span>回复</span>
                <span>顶(1)</span>
                <span>踩(0)</span>
              </div>
            </div>
          </div>
        </li>
      </ul>
    </div>
    <div id="reply-page" class="text-right my-4">
      <el-pagination background layout="prev, pager, next" :page-size="30" :total="1000">
      </el-pagination>
    </div>
    <div id="write-pad" class="w-[90%] m-auto">
      <el-tiptap v-model="content" :extensions="extensions" />
      <p class="my-4 text-right">
        <el-button type="primary">发送</el-button>
      </p>
    </div>
  </div>
</template>


<script>
import {
  Doc,
  Text,
  Paragraph,
  Heading,
  Bold,
  CodeBlock,
  Underline,
  Italic,
  Strike,
  ListItem,
  BulletList,
  OrderedList,
} from 'element-tiptap';
export default {
  name: 'PostDetailView',
  data() {
    return {
      extensions: [
        new Doc(),
        new Text(),
        new Paragraph(),
        new Heading({ level: 5 }),
        new Bold({ bubble: true }), // render command-button in bubble menu.
        new Underline({ bubble: true, menubar: false }), // render command-button in bubble menu but not in menubar.
        new Italic(),
        new Strike(),
        new CodeBlock(),
        new ListItem(),
        new BulletList(),
        new OrderedList(),
      ],
      // editor's content
      content: `
        
      `,
    }
  },
  components: {
  }
}
</script>

<style lang="less" scoped></style>