<template>
    <div>
        <w-flex justify-center  align-start :gap="4" class="mt1">
            <!-- <template v-for="n in [1,2,3,4]" :key="n">
                {{n}}
                <Card />
            </template> -->
            <Card class="Cards"/>
            <Card class="Cards"/>
            <Card class="Cards"/>
            <Card class="Cards"/>
        </w-flex>
        <div class="WelcomePanel">
            <h1>Welcome</h1>
            <div class="WelcomeImgContainer">

            </div>
            <div class="WelcomeParagraphContainer">
                <h3>IT ALL STARTED IN 2011…</h3>
                <p class="WelcomeParagraph">Hey, I’m Christopher Mitchell. I started this site a decade ago simply to reflect on my travels. Since then, I’ve lived on four continents, visited 80+ countries, written innumerable articles, and welcomed millions of visitors to my site. </p>
                <h4>Carefully written, extensively researched, award-winning.</h4>
            </div>
            <div class="WelcomeIconContainer">
                <a href="#"><i class="fa fa-facebook"></i></a>
                <a href="#"><i class="fa fa-instagram"></i></a>
                <a href="#"><i class="fa fa-twitter"></i></a>
            </div>
        </div>

        <div class="FeaturedPost">
            <div class="InnerDiv">
                <h1>Why travel is Important?</h1>
                <w-button class="ma1" bg-color="white" color="black" xl round><p>Read Here</p></w-button>
            </div>
        </div>

        <div class="FeaturedPosts">
            <div class="FeaturedPostCarousel">
                <p>North America</p>
                <w-flex  justify-center  align-start :gap="4" class="mt1">
                    <Card />
                    <Card />
                    <Card />
                </w-flex>
             </div>
             <div class="divider">
                <w-divider color="yellow-light3"  class="my6 mx-3"></w-divider>
             </div>
             <div class="FeaturedPostCarousel">
                <p>North America</p>
                <w-flex  justify-center align-start :gap="4" class="mt1">
                    <Card />
                    <Card />
                    <Card />
                </w-flex>
             </div>
             <div class="divider">
                <w-divider color="yellow-light3"  class="my6 mx-3"></w-divider>
             </div>
             <div class="FeaturedPostCarousel">
                <p>North America</p>
                <w-flex  justify-center  align-start :gap="4" class="mt1">
                    <Card />
                    <Card />
                    <Card />
                </w-flex>
             </div>
             <div class="divider">
                <w-divider color="yellow-light3"  class="my6 mx-3"></w-divider>
             </div>
             <div class="FeaturedPostCarousel">
                <p>North America</p>
                <w-flex   justify-center align-start :gap="4" class="mt1">
                    <Card />
                    <Card />
                    <Card />
                </w-flex>
             </div>

        </div>
        





    </div>
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
.WelcomePanel{
    margin: 10% 0px 10% 0px;
}
.divider{
    margin-left: -14%;
    margin-right: -14%;
}
.WelcomeImgContainer{
    height: 500px;
    border: 2px solid var(--secondary-color);
    margin: 4% 0px 8% 0px;

}
.WelcomeParagraph{
    margin : 4% auto 4% auto;
    width: 60%;
}
.WelcomeIconContainer{
    margin : 4% auto 4% auto;
    display:flex;
    align-items:center;
    justify-content:Center;
   
    
}
.WelcomeIconContainer .fa{
     padding:6px 6px;
    
}
.FeaturedPost{
    background-image : url(https://wallpaperaccess.com/full/138733.jpg);
    background-attachment: fixed;
    margin-left: -14%;
    margin-right: -14%;
    
}
.InnerDiv{
    padding: 20%;
}
.InnerDiv h1{
    width: 60%;
    margin : auto;
    font-size : 60px;

}
.InnerDiv button p{
    padding: 50px;
}
.FeaturedPosts{
    margin: 60px 0px 20px 0px;
}
.FeaturedPostCarousel{
    margin-top : 10%;
    margin-bottom : 15%;
}
.FeaturedPostCarousel p{
    display: block;
    
    font-size: 14px;
}
</style>