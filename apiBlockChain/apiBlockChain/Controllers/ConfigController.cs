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

        [HttpGet]
        [Route("getConfig/{id}")]
        public ActionResult<Configuracion> GetConfig(string id)
        {

           var configuracion = _configService.GetConfig(id);

            return Ok(configuracion);

        }


        [HttpPost]
        public ActionResult<Configuracion> InserConfiguracion(Configuracion configuracion)
        {

            _configService.InsertConfiguracion(configuracion);

            return Ok(configuracion);

        }

        [HttpPut]
        public ActionResult Update(Configuracion config) {
            _configService.UpdateConfig(config.Id, config);

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _configService.DeleteConfig(id);

            return Ok();
        }

    }
}
