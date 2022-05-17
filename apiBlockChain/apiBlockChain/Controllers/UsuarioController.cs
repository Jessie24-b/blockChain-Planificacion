﻿using apiBlockChain.Models;
using apiBlockChain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {

            _usuarioService = usuarioService;
        }


        [HttpGet]
        public ActionResult<List<Usuario>> GetUser()
        {

            return _usuarioService.GetList();

        }

        [HttpPost]
        public ActionResult<Usuario> InserUsuario(Usuario usuario)
        {

            _usuarioService.InsertUsuario(usuario);

            return Ok(usuario);

        }

    }
}
