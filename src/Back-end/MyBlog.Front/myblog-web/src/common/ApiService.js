
import axios from 'axios'
import VueAxios from 'vue-axios'
import app from '../main'
import {Api_URL} from './const'

export function init(app){
    app.use(VueAxios,axios);
}
const apiService = {
     get(controller,params = ""){
          var res = app.axios.get(`${Api_URL}/api/${controller}/${params}`);
          return res;    
    },

    post(controller,body){
        var res = app.axios.post(`${Api_URL}/api/${controller}`,body);
        return res;
    },
    put(controller,body){
        var res = app.axios.put(`${Api_URL}/api/${controller}`,body);
        return res;
    },
    delete(controller,params){
        var res = app.axios.delete(`${Api_URL}/api/${controller}`,{
            params : params
        });
        return res;
    }

}

export default apiService;



