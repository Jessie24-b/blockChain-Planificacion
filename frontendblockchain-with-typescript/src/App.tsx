import React from 'react';
import './styles/Login.css';
import './styles/formRegister.css';
import './js/validationForm';
import './App.css';
import Login from './components/loginComponent'
import { BrowserRouter, Routes, Route } from "react-router-dom";
import FormRegister from './components/formRegister';
import Home from './pages/Home';


function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path='/' element={ <Login/>}></Route>
      <Route path='/Register' element={ <FormRegister/>}></Route>
      <Route path='/Home' element={ <Home/>}></Route>
    </Routes>
  </BrowserRouter>


      
  );
}

export default App;
