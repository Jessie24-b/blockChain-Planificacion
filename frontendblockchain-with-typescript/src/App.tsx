import React from 'react';
import './styles/Login.css';
import './styles/formRegister.css';
import './styles/navbar.css';
import './js/validationForm';
import './App.css';
import Login from './components/loginComponent'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import FormRegister from './components/formRegister';
import Home from './pages/Home';
import Configuracion from './pages/configuracion';


function App() {
  return (
    
    <BrowserRouter>
    <Routes>
      <Route path='/' element={ <Login/>}></Route>
      <Route path='/Register' element={ <FormRegister/>}></Route>
      <Route path='/Home' element={ <Home/>}></Route>
      <Route path='/Configuracion' element={ <Configuracion/>}></Route>
    </Routes>
  </BrowserRouter>


      
  );
}

export default App;
