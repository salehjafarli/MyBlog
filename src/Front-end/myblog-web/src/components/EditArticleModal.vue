<template>
  <div class="FadeBackground">
    <div class="modal">
      <form action="">
        <div class="form">
          <div class="col" style="margin-right: 2px">
            <div>
              <div class="r3">
                <label class="mylbl" for="">Header</label>
                <input class="myinp" type="text" :value="SubmitData.header" />
              </div>
              <div class="r3">
                <label class="mylbl" for="">Category</label>
                <select class="myinp" type="text" v-model="SubmitData.category">
                  <option>South America</option>
                  <option>North America</option>
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
              <div style="display: flex" class="r3">
                <div>
                  <label class="mylbl" for="">Main image</label>
                  <input
                    class="myinp"
                    type="file"
                    accept="image/png, image/gif, image/jpeg"
                    @change="CheckInput($event)"
                  />
                </div>
                <div style="margin: auto" class="imageWrapper wrapper">
                  <img
                    v-bind:src="`data:image/jpg;base64,${this.SubmitData.mainImage}`"
                  />
                </div>
              </div>
            </div>
          </div>
          <div class="col" style="margin-left: 2px">
            <div style="height: 100%">
              <label class="mylbl" for="">Description</label>
              <div>
                <textarea
                  class="myinp wideInp"
                  type="text"
                  rows="12"
                  :value="description"
                />
              </div>
            </div>
          </div>
        </div>
        <h3 style="margin: 0">Sections:</h3>

        <div style="margin-top: 5px; margin-bottom: 0px">
          <div style="display: flex">
            <button
              @click.prevent="ChangeSection(index)"
              v-for="(section, index) in SubmitData.sections"
              :key="section.header"
              class="SecButton"
            >
              Sec {{ index + 1 }}
            </button>
          </div>
          <label class="mylbl" for="">Header</label>
          <input class="myinp" type="text" :value="currentSec.header" />
          <div style="display: flex" class="r3">
            <div>
              <label class="mylbl" for="">Section image</label>
              <input
                class="myinp"
                type="file"
                accept="image/png, image/gif, image/jpeg"
                @change="CheckInput($event)"
              />
            </div>
            <div style="margin: auto" class="imageWrapper wrapper">
              <img
                v-bind:src="`data:image/jpg;base64,${this.currentSec.image}`"
              />
            </div>
          </div>
          <label class="mylbl" for="">Section text</label>
          <div>
            <textarea
              class="myinp wideInp"
              rows="12"
              type="text"
              :value="currentSec.paragraph"
            />
          </div>
          <w-button @click="SubmitForm"  class="ma1" bg-color="yellow-light3" color="black" xl>Submit</w-button>
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
      currentSec: {},
    };
  },
  watch: {
    date: function (val) {
      this.inputVal = val;
    },
    sections: function (val) {
      this.currentSec = val[0];
      console.log(val);
    },
  },
  computed: {
    SubmitData() {
      return {
        header: this.header,
        mainImage: this.mainImage,
        date: this.date,
        description: this.description,
        sections: this.sections,
        category: this.category,
      };
    },
  },
  methods: {
    Submit($event) {
      this.$emit("CloseModal", $event);
    },
    ChangeSection(index) {
      this.currentSec = this.SubmitData.sections[index];
    },
    onInput(e) {
      var len = this.inputVal.length;

      if (
        len > 10 ||
        (e.inputType != "deleteContentBackward" &&
          "1234567890".indexOf(e.data) == -1)
      ) {
        this.inputVal = this.inputVal.slice(0, len - 1);
      } else if (e.inputType === "deleteContentBackward") {
        if (len == 5 || len == 2)
          this.inputVal = this.inputVal.slice(0, len - 1);
        return true;
      } else if (len == 2 || len == 5) {
        this.inputVal += "/";
      }
    },
    //eslint-disable-next-line
    CheckInput(e) {
      var file = e.srcElement.files[0];
      if (!"image/png, image/gif, image/jpeg".split(" ").includes(file.type)) {
        e.srcElement.value = "";
      }
      //eslint-disable-next-line
      var reader = new FileReader();
      reader.onload = function () {
        var str = reader.result;
        console.log(this.SubmitData);
        this.SubmitData.mainImage = str;
      }
      reader.readAsDataURL(file);

    },
    SubmitForm(){

    }
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
  height: 220px;
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
.SecButton {
  width: 5%;
  height: 20px;
}
.wrapper {
  height: 8%;
  width: 8%;
}
</style>
