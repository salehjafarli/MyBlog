<template>
  <w-app>
    <div style="height : 50px;">
      <Navbar @ChangeTab="ChangeTab"/>
    </div>
    <div class="pages">
      <component :is="CurrentTab"></component>
    </div>
    <Footer />
  </w-app>
</template>

<script>
import Navbar from './components/Navbar.vue'
import Home from './pages/Home.vue'
import Blog from './pages/Blog.vue'
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
    Footer
  },
  data() {
    return {
      CurrentTab : 'Contact'
    }
  },
  methods : {
    ChangeTab($event,tabName){
      this.CurrentTab = tabName;
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
</style>
