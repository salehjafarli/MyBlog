<template>
<div class="body">
    <h1>My Base Table</h1>
    <button @click="OpenArticle($event,0)" type="button" class="btn btn-save">
      <svg viewBox="0 0 32 32" class="icon">
        <use xlink:href="#icon-save"></use>
      </svg>
      <span>Add</span>
    </button>
<section> 
  <div class="table-container">
    <table>
      <thead class="TableHead">
        <tr> 
          <th>
            Articles
            <div>Articles</div>
          </th>
          <th>
            Categori
            <div>Categories</div>
          </th>
          <th> 
            Description
            <div>Description</div>
          </th>
          <th>
            Date
            <div>Date</div> 
          </th>
          <th>
            Actions
            <div>Actions</div>
          </th>
        </tr>
      </thead>
      <tbody>
           <tr v-for="Article in Articles" :key="Article.id">
          <td>{{Article.header}} {{Article.id}}</td>
          <td>{{Article.category}}</td> 
          <td>{{Article.description}}</td>
          <td>{{Article.date}}</td>
          <td class="actions">
            <button @click="OpenArticle($event,Article.id)" type="button" class="btn btn-save">
              <svg viewBox="0 0 32 32" class="icon">
                <use xlink:href="#icon-save"></use>
              </svg>
              <span>Update</span>
            </button>
            <button @click="DeleteArticle($event,Article.id)" type="button" class="btn btn-revert">
              <svg viewBox="0 0 32 32" class="icon">
                <use xlink:href="#icon-revert"></use>
              </svg>              
              <span>Delete</span>
            </button>
          </td>
      </tr>
        <tr>
          <td>width</td>
          <td>pixels, %</td> 
          <td>Not supported in HTML5. Specifies the width of a table</td>
          <td></td>
          <td class="actions">
            <button type="button" class="btn btn-save">
              <svg viewBox="0 0 32 32" class="icon">
                <use xlink:href="#icon-save"></use>
              </svg>
              <span>Update</span>
            </button>
            <button type="button" class="btn btn-revert">
              <svg viewBox="0 0 32 32" class="icon">
                <use xlink:href="#icon-revert"></use>
              </svg>              
              <span>Delete</span>
            </button>
          </td>
      </tr>
      </tbody>
    </table>
  </div>
</section>
</div>
</template>

<script>
export default {

    props : ['Articles'],
    methods : {
        OpenArticle($event,articleId){
            this.$emit('openArticle',$event,articleId);
        },
        DeleteArticle($event,articleId){
            this.$emit('deleteArticle',$event,articleId);
        }
    }

}
</script>

<style scoped>
.TableHead{
    
}

.body {
     margin-left: -14%;
     margin-right: -14%;
     padding: 0;
     font-weight: 200;
}
 h1 {
     margin: 0.25em;
}
 section {
     padding-top: 37px;
     width: 95%;
     margin: 0 auto;
     background :  var(--primary-color-v2);
}
 .table-container {
     overflow-y: none;
}
 table {
     border-spacing: 0;
     border-collapse: collapse;
     width: 100%;
}
 td, th {
     border: 0;
     border-left: 1px solid #eee;
     background: var(--primary-color);
     padding: 10px 25px;
}
 td:first-child, th:first-child {
     border: 0;
}
 tbody tr:nth-child(even) td {
     background: var( --primary-color-v2);
}
 th {
     height: 0;
     line-height: 0;
     padding-top: 0;
     padding-bottom: 0;
     color: transparent;
     border: none;
     white-space: nowrap;
}
 th div {
     background: transparent;
     color: #fff;
     padding: 9px 25px;
     margin-left: -25px;
     line-height: normal;
     border-left: 1px solid #eee;
}
 th:first-child div {
     border: none;
}
 .actions {
     white-space: nowrap;
     font-size: 0;
}
 .btn {
     text-transform: uppercase;
     color: white;
     display: inline-block;
     font-size: 12px;
     font-weight: 100;
     padding: 0 1em 0 2em;
     text-decoration: none;
     margin: 0 0.25em;
     line-height: 2em;
     min-height: 2em;
     color: #4e5c85;
     border: 1px solid #4e5c85;
     transition: all 0.1s linear;
}
 .btn:hover {
     cursor: pointer;
     color: white;
     border: 1px solid #1b2952;
     background: #4e5c85;
}
 .btn svg {
     height: 1em;
     fill: currentColor;
}
 .btn.btn-save, .btn.btn-query, .btn.btn-run {
     color: #339233;
     border: 1px solid #339233;
     transition: all 0.1s linear;
}
 .btn.btn-save:hover, .btn.btn-query:hover, .btn.btn-run:hover {
     cursor: pointer;
     color: white;
     border: 1px solid #005f00;
     background: #339233;
}
 .btn.btn-revert {
     color: #923333;
     border: 1px solid #923333;
     transition: all 0.1s linear;
}
 .btn.btn-revert:hover {
     cursor: pointer;
     color: white;
     border: 1px solid #5f0000;
     background: #923333;
}
 tbody tr td:last-child {
     white-space: nowrap;
     font-size: 0;
}
 @media (max-width: 1200px) {
     tbody tr td:last-child .btn {
         padding: 0 1em;
         border: 0;
         background: transparent;
    }
     tbody tr td:last-child .btn svg {
         height: 1.5em;
    }
     tbody tr td:last-child .btn span {
         display: none;
    }
     tbody tr td:last-child .btn:hover {
         border: 0;
    }
}
 

</style>