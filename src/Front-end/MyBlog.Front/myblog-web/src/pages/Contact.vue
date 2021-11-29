<template>
    <div>
        <h1>Work With Me</h1>
        <div class="WorkWithMe">
            <div class="xs4 image"></div>
            <div class="xs8 text">
                <h2>Working with others? It's kind of a passion of mine.</h2>
                <p>I've worked with magazines, tourism boards, hotels, other travel bloggers, corporations and businesses, conferences, photographers - the works. You name it, I've likely collaborated or worked on it.</p>
                <p>Please head to my Portfolio if you'd like to see examples of my work in a variety of capacities.</p>
                <p>I’ve also got a portfolio site to showcase all that I’m up to. </p>
            </div>
        </div>
        <div class="FormTop">
            <p style="font-size:20px;text-align:left">To those looking to write a guest post - I kindly thank you for your interest but, at this time, I'm not looking for any additional writers. </p>
            <p><strong>Email me if you've got a question, concern, offer, or anything in between. </strong></p>
            <div class="Email">
                 <span><i class="fa fa-envelope"></i></span>
                 <span style="font-size:40px;">info@websitename.com</span>
            </div>
            <p><em>or, if it's easier, just use form below.</em></p>
        </div>

        <div class="ContactForm">
            <form action="">
                <w-flex :gap="4">
                    <w-input
                        color="yellow-light3"
                        class="mb4"
                        label="Name"
                        outline>
                    </w-input>
                    <w-input
                        color ="yellow-light3"
                        class="mb4"
                        label="Last Name"
                        outline>
                    </w-input>
                </w-flex>
                <w-input
                    color ="yellow-light3"
                    class="mb4"
                    label="Email Adress"
                    outline>
                </w-input>
                <w-input
                    color ="yellow-light3"
                    class="mb4"
                    label="Subject"
                    outline>
                </w-input>
                <w-input
                    color ="yellow-light3"
                    class="mb4"
                    label="Message"
                    outline
                    >
                </w-input>

                <w-button style="margin-bottom:2%" class="ma1" bg-color="yellow-light3" color="black" xl>Submit</w-button>
            </form>
        </div>
       


    </div>
</template>

<script>
export default {

}
</script>

<style>
h1{
    font-size : 60px;
    font-weight: 20;
}
.WorkWithMe{
    margin-top: 5%;
    display: flex;
}
.text{
    padding: 5% 10% 10% 10%;

}
.text > * {
    text-align: left;
    font-weight: 20;
}
.text h2{
    font-size : 30px;
    margin-bottom: 10%;
}
.text > p {
    margin: 30px 0;
    font-size : 20px;
}
.image{
    height: 600px;
    border : 2px solid var(--secondary-color);
}
.FormTop{
    margin-top : 2%;
}
.FormTop > *{
    margin-top : 2%;
    margin-bottom : 2%;
}
.Email > *{
    color : var(--secondary-color);
    margin-left : 2%;
}
.fa-envelope{
    font-size:40px;
}

.ContactForm{
    margin-top : 3%;
    margin-bottom : 10%;
    border : 2px solid var(--secondary-color);
}
   
form > * {
    margin-top : 3%;
    margin-bottom : 3%;
    text-align: left;
}
</style>