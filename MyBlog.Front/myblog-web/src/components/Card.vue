<template>
    <div class="card">
        <w-card  shadow>
            <div class="imageContainer">
                <img v-bind:src="imgsrc" />
            </div>
            <date class= 'date'>{{date}}</date>
            <p>
                {{Header}}
            </p>
        </w-card>
    </div>
    
</template>

<script>
export default {
    props : ['Header','date','imgsrc'],
    Name : "Card"
}
</script>

<style>
.card{
    border : 2px solid var(--secondary-color);

}
.card p{
    font-size: 20px;
}
.imageContainer{
    height: 100px;
}

</style>