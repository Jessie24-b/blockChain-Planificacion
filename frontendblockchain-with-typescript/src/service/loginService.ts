import axios from "axios";
import {User} from '../types'

 export default function getUsers ()  {   

      return   axios.get<User>('https://localhost:44317/api/Usuario').then((response ) => {
            console.log(JSON.stringify(response.data))
      });
      /* response.then((value) => {
            console.log(value.user);
           
             return response
          }); */

     
}