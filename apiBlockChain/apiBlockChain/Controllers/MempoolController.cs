using apiBlockChain.Models;
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
    public class MempoolController : Controller
    {

        public MempoolService _mempoolService;

        public MempoolController(MempoolService mempoolService)
        {

            _mempoolService = mempoolService;
        }
        [HttpPost]
        public ActionResult<Mempool> InsertMeempool(Mempool mempool)
        {


            _mempoolService.InsertMempool(mempool);

            return Ok(mempool);

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMempool(string id)
        {
            _mempoolService.DeleteMempool(id);

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetListMempool()
        {

            return Ok(await _mempoolService.GetListMempool());


        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Configuracion> GetFile(string id)
        {

            var configuracion = _mempoolService.GetFile(id);

            return Ok(configuracion);

        }
    }
}
