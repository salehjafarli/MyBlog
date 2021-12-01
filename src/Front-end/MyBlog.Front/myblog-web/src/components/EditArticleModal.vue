<template>
<div class="FadeBackground">
   <div class="modal">
     <form action="">
                <w-flex :gap="4">
                    <w-input :value="header"
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
                <w-button @click="Submit" style="margin-bottom:2%" class="ma1" bg-color="yellow-light3" color="black" xl>Submit</w-button>
            </form>

            

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
  data() {
    return {
      isOpen: true
    }
  },
  methods : {
      Submit($event){
        
          this.$emit('CloseModal',$event);
      }
  },
  created(){
    alert(this.header);
  }
}
</script>
<style scoped>
* {
   box-sizing: border-box;
}
.FadeBackground{
  
  position: absolute;
}
.FadeBackVisible{
  background:rgba(255,255,255, 0.5);
  top: 0; left:0; height: 100%; width: 100%;
  z-index: 11;
}
 .modal {

   position: absolute;
   margin : auto;
   background-color: black;
   border : 2px solid var(--secondary-color);
   top : 25%;
   width: 75%;
   font-size: 14px;
   opacity: 0;
   transform: translateY(-10%);
   transition: opacity 0.5s, transform 0.5s;
   pointer-events: none;
   padding-bottom: 10px;
}
 .modal:hover {
   opacity: 1;
   pointer-events: all;
   transform: translateY(0%);
}
 .modal.open {
   position: relative;
   opacity: 1;
   z-index: 12;
   pointer-events: all;
   background-color: black;
   transform: translateY(0%);
}
 .modal > div:first-child {
   position: relative;
   background: #fff;
   padding: 5px 10px;
   display: flex;
   align-items: center;
   gap: 10px;
}
 .modal > div:first-child > div {
   position: relative;
   height: 15px;
   width: 15px;
   left: 5px;
   display: flex;
   align-items: center;
   gap: 2px;
   cursor: pointer;
}
 .modal > div:first-child > div:hover span:first-child {
   background: #000;
   box-shadow: 0 0 0 1px #fff, 0 0 0 2px #000, 0 0 0 3px #fff, 0 0 0 4px #000;
}
 .modal > div:first-child > div:hover span:last-child {
   border-right: 5px solid #000;
}
 .modal > div:first-child > div:hover span:last-child:before {
   background: #000;
}
 .modal > div:first-child > div span:first-child {
   width: 2.5px;
   position: absolute;
   left: 5px;
   aspect-ratio: 1;
   background: #b5b5b5;
   border-radius: 50%;
   box-shadow: 0 0 0 1px #fff, 0 0 0 2px #b5b5b5, 0 0 0 3px #fff, 0 0 0 4px #b5b5b5;
}
 .modal > div:first-child > div span:first-child:after {
   content: "";
   position: absolute;
   width: 15px;
   aspect-ratio: 1;
   background: #fff;
   top: -6px;
   left: -13px;
}
 .modal > div:first-child > div span:last-child {
   position: absolute;
   left: 0px;
   background: #fff;
   height: 10px;
   content: "";
   border-top: 5px solid transparent;
   border-bottom: 5px solid transparent;
   border-right: 5px solid #b5b5b5;
   z-index: 6;
}
 .modal > div:first-child > div span:last-child:before {
   content: "";
   position: absolute;
   top: -2.5px;
   width: 5px;
   left: -1px;
   aspect-ratio: 1;
   background: #b5b5b5;
}
 .modal > div:last-child {
   padding: 10px;
   background: #286f8a;
   line-height: 1.5em;
   color: #fff;
}
 .modal > div:last-child:after {
   position: absolute;
   bottom: 5px;
   left: 50%;
   transform: translate(-50%) rotate(45deg);
   content: "";
   width: 15px;
   aspect-ratio: 1;
   background: inherit;
}
 .modal > div:last-child span {
   font-weight: 600;
}
 

</style>
