<template>
    <div class="navbar">
        <w-toolbar class="navbarcontent" bg-color="black" color ="white" height = "50px">
            <img src="../assets/logo.png" height="20">    
            <div style="padding-left:20px" class="title2">MyBlog</div>
            <div class="spacer" ></div>
            <div class="Pages">
                <span class="ml5">Home</span>
                <span class="ml5">Blog</span>
                <span class="ml5">Contact</span>
                <span class="ml5">Newsletter</span>
            </div>
          </w-toolbar>
    </div>
</template>

<script>
export default {
    data : () => {
        
        
    },
    created(){
    }

}
</script>

<style scoped>

.navbar{
    background-color: black;
    display: block;
    height: 100%;
}
.navbarcontent{
    width: 60%;
    margin: auto;
}
.Pages{
    
}
.title2{
    color: var(--secondary-color);
}

</style>