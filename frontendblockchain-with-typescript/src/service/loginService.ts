import axios from "axios";




 export default function GetUsers (user: string)  {   
     
     

        axios.get('https://localhost:44317/api/Usuario/'+user).then(response  => {
           console.log(response.data);
            if(response.status === 200){
                  console.log("perfect");
                  window.location.href  = "/Home";
            }else{
                  console.log("este usuario no existe");
            }

           
      });

      return true;
     
}