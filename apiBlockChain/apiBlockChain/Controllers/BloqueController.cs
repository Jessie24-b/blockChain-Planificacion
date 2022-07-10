using apiBlockChain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class BloqueController : Controller { 

         public MinadoService _minado;


    public BloqueController(MinadoService minadoService)
    {


        _minado = minadoService;
    }


    
        [HttpGet]
        public async Task<IActionResult> GetListBloques()
        {
            return Ok(await _minado.GetList());

        }
    }
}
