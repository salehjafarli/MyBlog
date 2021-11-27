<template>
    <div class="card">
        <w-card  shadow>
            <div class="imageContainer">
            </div>
            <time class= 'date'>2021-12-12</time>
            <p>
                Lorem ipsum, dolor sit amet consectetur adipisicing elit.
            </p>
        </w-card>
    </div>
    
</template>

<script>
export default {
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