<template>
  <div class="FadeBackground">
    <div class="modal">
      <form action="">
        <div class="form">
          <div class="col" style="margin-right: 2px">
            <div class="r3">
              <label class="mylbl" for="">Header</label>
              <input class="myinp" type="text" :value="'salam'" />
            </div>
            <div class="r3">
              <label class="mylbl" for="">Category</label>
              <select class="myinp" type="text">
                <option>North America</option>
                <option>South America</option>
                <option>Europe</option>
                <option>Asia</option>
                <option>Africa</option>
                <option>Australia</option>
              </select>
            </div>
            <div class="r3">
              <label class="mylbl" for="">Date</label>
              <input
                class="myinp"
                type="text"
                v-model="inputVal"
                @input="onInput($event)"
              />
            </div>
            <div class="r3">
              <label class="mylbl" for="">Main image</label>
              <input class="myinp" type="file">
            </div>
          </div>
          <div class="col" style="margin-left: 2px">
            <div style="height: 100%">
              <label class="mylbl" for="">Description</label>
              <div>
                <textarea class="myinp wideInp" type="text" :value="'salam'" />
              </div>
            </div>
          </div>
        </div>
        

        <div>

          
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
      inputVal: "",
    };
  },
  methods: {
    Submit($event) {
      this.$emit("CloseModal", $event);
    },
    asd() {
      alert("asfasf");
    },
    onInput(e) {
      var len = this.inputVal.length;
      if (len > 10 || "1234567890".indexOf(e.data) == -1) {
        this.inputVal = this.inputVal.slice(0, len - 1);
      } else if (e.inputType === "deleteContentBackward") {
        if (len == 5 || len == 2)
          this.inputVal = this.inputVal.slice(0, len - 1);
        return true;
      } else if (len == 2 || len == 5) {
        this.inputVal += "/";
      }
    },
  },
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

.col {
  width: 50%;
  padding: 12px;

  height: 200px;
}
.r3 {
  height: 33%;
}
.form {
  position: relative;
  width: 100%;
  display: flex;
}
.myinp {
  width: 100%;
  background-color: black;
  border: 1px solid var(--secondary-color);
  padding: 10px;
  color: var(--secondary-color);
}
.mylbl {
  color: var(--secondary-color);
}
.wideInp {
  resize: none;
  height: 100%;
}
</style>
