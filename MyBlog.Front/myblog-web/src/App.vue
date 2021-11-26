<template>
  <w-app>
    <div style="height : 50px;">
      <Navbar />
    </div>
    <div class="pages">
      <Home />
    </div>
    <w-button>Test</w-button>
    <Footer />
  </w-app>
  
</template>

<script>
import Navbar from './components/Navbar.vue'
import Home from './pages/Home.vue'
import Footer from './components/Footer.vue'

export default {
  name: 'App',
  components: {
    Home,
    Navbar,
    Footer
  },
  data : () => {
  },
  created(){
  }
}
</script>

<style>
@import './styles/colors.css';
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color : var(--font-color);
}
.pages{
  width : 60%;
  margin: 4% auto 0px auto;
}
</style>
