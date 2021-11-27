<template>
    <div>
        <h1 >Join My Newsletter!</h1>
        <div>
            <div class="wyjoin">
                <h2>Why join, you ask? </h2>
                <ul>
                    <li>it’s totally free, and always will be. </li>
                    <li>I offer travel tips and tricks that I’ve learned from living on 4 continents and travelling to over 80 countries over the last decade or so.  </li>
                    <li> I dive into the can’t miss travel movies, books, podcasts, TV shows, and so much more!</li>
                    <li>Thousands of others have joined, and the number one piece of feedback that I get is that I offer value. </li>
                    <li>I talk about travel in a way that anyone can appreciate.</li>
                </ul>
                <p style="font-size:16px;margin-top:1.5%;">So why wait?</p>
            </div>
        </div>

        <div class="EmailCard">
            <div class="AddEmailImgContainer">
            </div>
            <div class="EmailCardFormContainer">
                <p style="font-size:30px">Simply add your email below!</p>
                <em style="font-size:14px">Travel tips and tricks, with none of the bull. And it's free.</em>
                <form>
                    <w-input
                        style="font-size:16px;text-align:center"
                        color ="yellow-light3"
                        class="mb4"
                        label="Email"
                       
                        outline>
                    </w-input>
                    <w-button  style="width:80%" class="ma1" bg-color="yellow-light3" color="black" xl>Submit</w-button>
                </form>
            </div>

        </div>


    </div>
  
</template>

<script>
export default {

}
</script>

<style>
.wyjoin{
    text-align: left;
    margin-top: 4%;

}
li{
    font-size:16px;
    margin-top:1.5%;
    
}
ul{
    margin-left: 3%;
}
.AddEmailImgContainer{
    height: 300px;
    border : 2px solid var(--secondary-color);
    
}
.EmailCard{
    width: 26%;
    margin:4% auto 0px auto;
}
.EmailCardFormContainer{
    padding: 20px 0px 0px 0px ;
    background-color: var(--primary-color-v2);
}
.EmailCardFormContainer > * {
    margin-bottom : 4%;
}

</style>