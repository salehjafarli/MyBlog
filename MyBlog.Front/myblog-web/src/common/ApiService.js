
import axios from 'axios'
import VueAxios from 'vue-axios'
import app from '../main'
import {Api_URL} from './const'

export function init(app){
    app.use(VueAxios,axios);
}
const apiService = {
     get(){
          var res = app.axios.get(`${Api_URL}/api/article`);
          return res;
            
    }

}

export default apiService;



