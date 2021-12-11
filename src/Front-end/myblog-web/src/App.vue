<template>
  <w-app>
    <div style="height : 50px;">
      <Navbar @ChangeTab="ChangeTab"/>
    </div>
    <div class="pages">
      <component v-bind="CurrentTab == 'ArticlePage' ? Article : {}" @ArticleClicked ="OpenArticle" :is="CurrentTab"></component>
    </div>
    <Footer />
  </w-app>
</template>

<script>
import Navbar from './components/Navbar.vue'
import Home from './pages/Home.vue'
import Blog from './pages/Blog.vue'
import Panel from './pages/Panel.vue'
import ArticlePage from './pages/ArticlePage.vue'
import Contact from './pages/Contact.vue'
import Newsletter from './pages/Newsletter.vue'
import Footer from './components/Footer.vue'
export default {
  name: 'App',
  components: {
    Home,
    Blog,
    Contact,
    Newsletter,
    Navbar,
    Footer,
    ArticlePage,
    Panel
  },
  data() {
    return {
      CurrentTab : 'Panel',
      Article : {}
    }
  },
  methods : {
    ChangeTab($event,tabName){
      this.CurrentTab = tabName;
    },
    OpenArticle($event,article){
      this.Article = article;
      this.CurrentTab = 'ArticlePage'
      
    }
  },
  created(){
  }
}
</script>

<style>
@import './styles/colors.css';
@import url(//db.onlinewebfonts.com/c/2a38b67077793ce5a08d86cd0edc5f33?family=Wilma+Mankiller+old+Lt+SmCn);
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color : var(--font-color);
  
}
.pages{
  width : 80%;
  margin: 4% auto 0px auto;
}
.imageWrapper{
  position: relative;
  overflow: hidden;
  height: 100%;
}
.imageWrapper > img{
   width: 100%;  
}
</style>
