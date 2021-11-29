<template>
    <div>
        <w-flex wrap justify-center  :gap="10" class="mt1" >
            <Card @click="OpenBlog" v-bind="article"
             class="Cards" v-for="article in getArticles" v-bind:key="article.id" />
        </w-flex>
        <div class="PaginationContainer">
            <!--eslint-disable-next-line-->
            <Pagination v-model:value="page"
            :rows-number="rows"
            rows-per-page="5" />
        </div>
    </div>
</template>

<script>
import Card from '../components/Card.vue'
import Pagination from '../components/Pagination.vue'
import {mapGetters, mapActions} from 'vuex' 

export default {
    components:{
        Card,
        Pagination
    },
    data()
    {
        return{
            nums : [...Array(20).keys()],
            page:2,
            rows:31,
            description : ''
        }
    },
    computed : {
        ...mapGetters(['getArticles','getById'])
    },
    methods : {
        ...mapActions(['FetchArticles']),

        OpenBlog(event,id){
          var article = this.getById(id);  
          this.$emit('ArticleClicked',event,article);
        }
    },
    created(){
       this.FetchArticles();
       
    }

}
</script>

<style>
.Cards{
    width: 22%;
}
.PaginationContainer{
    margin-top : 5%;
    display: flex;
    align-items: center;
    justify-content: center;
}

</style>