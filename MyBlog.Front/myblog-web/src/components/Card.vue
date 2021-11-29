<template>
    <div  @click="$emit('click',$event,id)" class="card">
        <w-card  shadow>
            <div class="imageWrapper">
                 <img class="mainImage" v-bind:src="`data:image/jpg;base64,${mainImage}`" />
            </div>
            <date  class= 'date'>{{date}}</date>
            <p class="header">{{header}}</p>
            <p class="desc">{{description}}</p>
        </w-card>
    </div>
</template>

<script>
export default {
    emits : ['click'],
    props : {
        id : Number,
        header : String,
        date : String,
        mainImage : String,
        description : String

    },
    Name : "Card"
}
</script>

<style scoped>
.card{
    border : 2px solid var(--secondary-color);
}
*{
    text-align: left;
}
.card .header{
    font-size: 24px;
    margin: 2% 0% 2% 0%;
    
}
.date{
    font-size:12px;
}
.desc{
    font-size: 14px;
}
.imageContainer{
    height: 100px;
}

</style>