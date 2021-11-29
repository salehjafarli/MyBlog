import ApiService from '../common/ApiService'
export default {
    state : {
        Articles : [
            {
                id : 2,
                header : 'a',
                date : new Date(),
                mainImage : '',
                description : 'description',
                sections : [
                    {
                        header : 'asd',
                        image : 'asd',
                        paragraph : 'asd'

                    }
                ]
            }

        ]
    },
    getters : {
        getArticles(state){
            return state.Articles;
        },
        getById(state){
            return (id) => state.Articles.find(art => art.id == id );
        }

    },
    actions : {
        async FetchArticles(context){
            var response = await ApiService.get('article');
            context.commit('SetArticle',response.data);

        }

    },
    mutations : {
        //eslint-disable-next-line
        SetArticle(state,articles){
            state.Articles = articles;
            UpdateDates(state.Articles);
            console.log(state.Articles);
        }
    }
}

function UpdateDates(articles){
    articles.forEach(article => {
        article.date = new Date(article.date).toDateString();
    });
}