<template>
    <div>
        <w-flex wrap justify-center  :gap="10" class="mt1" >
            <Card class="Cards" v-for="n in nums" v-bind:key="n" />
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
            rows:20
        }
    }
}
</script>

<style>
.Cards{
    width: 20%;
}
.PaginationContainer{
    margin-top : 5%;
    display: flex;
    align-items: center;
    justify-content: center;
}

</style>