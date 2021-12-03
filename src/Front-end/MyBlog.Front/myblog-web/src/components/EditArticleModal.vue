<template>
  <div class="FadeBackground">
    <div class="modal">
      <form class="form" action="">
        <div class="col" style="margin-right : 2px">
          <label class="mylbl" for="">Header</label>
          <input class="myinp" type="text" :value="'salam'" />
          <label class="mylbl" for="">Description</label>
          <textarea class="myinp wideInp" type="text" :value="'salam'" />
        </div>
        <div class="col" style="margin-left : 2px">
           <label class="mylbl" for="">Category</label>
           <select class="myinp" type="text">
             <option>North America</option>
             <option>South America</option>
             <option>Europe</option>
             <option>Asia</option>
             <option>Africa</option>
             <option>Australia</option>
           </select>
          <label class="mylbl" for="">Date</label>
          <input class="myinp" type="text" v-model="inputVal"  v-on:keyup.backspace="DeleteInp" @input="onInput"/>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    id: Number,
    header: String,
    mainImage: String,
    date: String,
    description: String,
    sections: Array,
    category: String,
  },
  data() {
    return {
      isOpen: true,
      inputVal : '',
      inputCounter : 0,
    };
  },
  methods: {
    Submit($event) {
      this.$emit("CloseModal", $event);
    },
    onInput(){
      this.inputCounter++;
      var len = this.inputVal.length; 
      if( len == 2 || len == 5){
        this.inputVal += '/';
      }
      if(len > 10){
        this.inputVal = this.inputVal.slice(0,len-1);
      }
    },
    DeleteInp(){
      alert('tst');
        var len = this.inputVal.length; 
        this.inputVal = this.inputVal.slice(0,len-1);
        
    }
  }
};
</script>
<style scoped>
/* #region  */
* {
  box-sizing: border-box;
}

.FadeBackground {
  position: absolute;
}
.FadeBackVisible {
  background: rgba(255, 255, 255, 0.5);
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  z-index: 11;
}
.modal {
  position: absolute;
  margin: auto;
  background-color: black;
  border: 2px solid var(--secondary-color);
  top: 25%;
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


/* #endregion  */

.col{
  width : 50%;
  padding : 12px;
}
.form{
  position: relative;
  width : 100%;
  display : flex;
}
.myinp{
  width : 100%;
  background-color:black;
  border : 1px solid var(--secondary-color);
  padding : 10px;
  color : var(--secondary-color);
}
.mylbl  {
  color : var(--secondary-color);
}
.wideInp{
  padding-bottom : 50px;
  resize: none;
}

 
</style>
