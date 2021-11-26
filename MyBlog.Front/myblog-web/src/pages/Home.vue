<template>
    <w-flex align-start :gap="4" class="mt1">
        <!-- <template v-for="n in [1,2,3,4]" :key="n">
            {{n}}
            <Card />
        </template> -->
        <Card />
        <Card />
        <Card />
        <Card />
    </w-flex>
</template>

<script>
import Card from '../components/Card.vue'
export default {
    Name : "Home",
    components :{
        Card
    }
}
</script>

<style>


</style>