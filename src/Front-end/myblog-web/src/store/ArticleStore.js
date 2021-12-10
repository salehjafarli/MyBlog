import ApiService from '../common/ApiService'
import CategoryHelper from '../common/CategoryHelper';
export default {
    state : {   
        Articles : [
            {
                id : 0,
                header : 'a',
                date : new Date(),
                mainImage : '',
                description : 'description',
                category : 'a',
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
        //eslint-disable-next-line
        getById(state){
            return (id) =>
            { 
                return state.Articles.find(art => art.id == id );
            };
        }

    },
    actions : {
        async FetchArticles(context){
            var response = await ApiService.get('article');
            context.commit('SetArticle',response.data);

        },
        async FetchArticleById(context,id){
            var response = await ApiService.get('article',id);
            context.commit('SetArticleById',response.data);
        }

    },
    mutations : {
        //eslint-disable-next-line
        SetArticle(state,articles){
            articles.forEach(element => {
                element.category = CategoryHelper.GetCategoryName(element.category);
            });
            state.Articles = articles;
            state.Articles.forEach(article => {
                UpdateDate(article);
            });
        },
        SetArticleById(state,article){
            article.category = CategoryHelper.GetCategoryName(article.category);
            state.Articles = [
                ...state.Articles.filter(element => element.id !== article.id),
                article
            ]
            state.Articles.forEach(article => {
                UpdateDate(article);
            });
        }
    }
}

function UpdateDate(article){
        var date = article.date;
        
        var temp = date.match(/[0-9]{4}-[0-9]{2}-[0-9]{2}/g)[0].split("-");
        var cooldate = temp.reverse().join('/');
        console.log(cooldate);
        article.date =cooldate;
}