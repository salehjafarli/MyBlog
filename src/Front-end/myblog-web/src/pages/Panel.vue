<template>
  <div class="Table">
    <Table
      @openArticle="openArticle"
      @deleteArticle="deleteArticle"
      v-bind:Articles="getArticles"
    />
    <EditArticleModal v-bind="article" @closeModal="openModal" />
  </div>
</template>

<script>
import Table from "../components/Table.vue";
import { mapGetters, mapActions } from "vuex";
import EditArticleModal from "../components/EditArticleModal.vue";
export default {
  components: {
    Table,
    EditArticleModal,
  },
  data() {
    return {
      article: { header: "teasdasdst" },
      isOpen: false,
    };
  },
  computed: {
    ...mapGetters(["getArticles", "getById"]),
  },
  methods: {
    ...mapActions(["FetchArticles", "FetchArticleById"]),
    //eslint-disable-next-line
    async openArticle($event, id) {
      var article;
      if (id !== 0) {
        await this.FetchArticleById(id);
        article = this.getById(id);
      }

      this.openModal(article);
    },
    //eslint-disable-next-line
    deleteArticle($event, id) {},
    //eslint-disable-next-line
    openModal(article) {
      const elModal = document.querySelector(".modal");
      const background = document.querySelector(".FadeBackground");
      if (!this.isOpen) {
        this.article = article;
        // console.log(this.article);
        this.isOpen = true;
        elModal.classList.add("open");
        background.classList.add("FadeBackVisible");
      } else {
        this.isOpen = false;
        elModal.classList.remove("open");
        background.classList.remove("FadeBackVisible");
      }
    },
  },
  async created() {

    

    try {
      await this.FetchArticles();
    } catch (error) {
      console.log(error);
    }
  },
  mounted() {
    // const elModal = document.querySelector(".modal");
    // const background = document.querySelector(".FadeBackground");
    // elModal.classList.add("open");
    // background.classList.add("FadeBackVisible");
  },
};
</script>

<style scoped>
.Table {
  display: block;
}
</style>