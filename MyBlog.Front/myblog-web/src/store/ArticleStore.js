import ApiService from '../common/ApiService'
export default {
    state : {
        Articles : [
            {
                header : '',
                date : new Date(),
                mainImage : '',
                
                
            }

        ]
    },
    getters : {
        getArticles(state){
            return state.Articles;
        } 

    },
    actions : {
        async FetchArticles(context){
            var response = await ApiService.get();
            context.commit('SetArticle',response.data);

        }

    },
    mutations : {
        //eslint-disable-next-line
        SetArticle(state,articles){
            state.Articles = articles;
            console.log(state.Articles);
        }
    }
}