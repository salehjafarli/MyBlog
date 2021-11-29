<template>
<div class="ArticleContainer">
    <div class="DateCategorySection">
     <p >{{date}}</p>
     <i class="fa fa-circle"></i>
     <p>{{category}}</p>
    </div>
    <h1>{{header}}</h1>
    <h2>{{description}}</h2>
    <div class="imageWrapper">
    <img  :src="`data:image/jpg;base64,${mainImage}`" alt="">
    </div>
    <div v-for="sec in sections" :key="sec.header" class="SectionContainer">
        <h1>{{sec.header}}</h1>
        <div class="imageWrapper">
            <img  :src="`data:image/jpg;base64,${sec.image}`" alt="">
        </div>
        <p>{{sec.paragraph}}</p>
    </div>

</div>
  
</template>

<script>
export default {
    props : {
        header : String,
        mainImage : String,
        date : String,
        description : String,
        sections : Array,
        category : String
    },
    data(){
        //eslint-disable-next-line
    },
    created(){
    },
    methods : {
    }
}
</script>

<style scoped>

.ArticleContainer{
    margin-top: 5%;
}
.DateCategorySection{
    margin : auto;
    width: 20%;
    justify-content: center;
    display: flex;
    font-size : 14px;
}
.DateCategorySection > * {
}
.DateCategorySection > i{
    font-size: 6px;;
    margin : auto 4% auto 4%;
}
.ArticleContainer  h1{
    margin: 5% 0px 5% 0px;
}

.ArticleContainer > .imageWrapper{
    margin : 5% 0% 5% 0%;
}
.ArticleContainer p {
    text-align: left;
    white-space: pre-line;
    line-height: 1.5;


}

.ImageContainer{
    height: 200px;
    border: 2px solid var(--secondary-color);
    margin : 5% 0px 5% 0px;
}


</style>
