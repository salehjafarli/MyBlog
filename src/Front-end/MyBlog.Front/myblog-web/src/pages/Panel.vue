<template>
  <div class="Table">
      <h1>{{article.header}}</h1>
      <Table  @openArticle="openArticle" @deleteArticle="deleteArticle"  v-bind:Articles="getArticles" />
      <component :is="'EditArticleModal'" @v-bind:header="'test'" @closeModal="openModal" />
  </div>

</template>

<script>
import Table from '../components/Table.vue'
import {mapGetters, mapActions} from 'vuex'
import EditArticleModal from '../components/EditArticleModal.vue'
export default {
    components : {
        Table,
        EditArticleModal
    },
    data(){
        return {
            article : {header:'test'},
            isOpen : true
        }
    },
    computed:{
        ...mapGetters(['getArticles','getById'])
    },
    methods : {
        ...mapActions(['FetchArticles','FetchArticleById']),
        //eslint-disable-next-line
        async openArticle($event,id){
            var article;
            if(id !== 0){
                await this.FetchArticleById(id);
                article = this.getById(id);
            }
            
            this.openModal(article);
        },
         //eslint-disable-next-line
        deleteArticle($event,id){

        },
        openModal(article){
            const elModal = document.querySelector('.modal');
            const background = document.querySelector('.FadeBackground');
            if (!this.isOpen){
                this.article = article;
                this.isOpen = true;
                elModal.classList.add('open');
                background.classList.add('FadeBackVisible');
            }
            else 
            {
                this.isOpen = false;
                elModal.classList.remove('open');   
                background.classList.remove('FadeBackVisible');
            }
        }
    },
    async created(){
        await this.FetchArticles();
        // const elModal = document.querySelector('.modal');
        // const background = document.querySelector('.FadeBackground');
        // elModal.classList.add('open');
        // background.classList.add('FadeBackVisible');
        
    },
    mounted(){
        //this.openModal();
    }
}
</script>

<style scoped>
.Table{
    display: block;
}
</style>