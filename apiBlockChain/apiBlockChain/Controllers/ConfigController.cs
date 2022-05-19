using apiBlockChain.Models;
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
    public class ConfigController : ControllerBase
    {

        public ConfiguracionService _configService;


        public ConfigController(ConfiguracionService configuracionService) {

            
             _configService = configuracionService;
        }
       

        [HttpGet]
        public async Task<IActionResult> GetConfiguraciones()
        {

            return Ok(await _configService.GetList());
           

        }

        
       [HttpPost]
       public ActionResult<Configuracion> InserConfiguracion(Configuracion configuracion)
       {

           _configService.InsertConfiguracion(configuracion);

           return Ok(configuracion);

       }
       
    }
}
