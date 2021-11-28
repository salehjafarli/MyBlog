import { createApp } from 'vue'
import App from './App.vue'
import WaveUI from 'wave-ui'
import 'wave-ui/dist/wave-ui.css'
import store from './store'
import {init} from './common/ApiService'

const app = createApp(App);
app.use(store);
init(app);

new WaveUI(app, {
    // Some Wave UI options.
  })
export default app;

app.mount('#app')
