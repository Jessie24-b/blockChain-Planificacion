using apiBlockChain.Models;
using apiBlockChain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using apiBlockChain.Logic;

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

        /*
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Configuracion> GetFile(string id)
        {

            var configuracion = _mempoolService.GetFile(id);

            return Ok(configuracion);

        }
        */

        [HttpGet]
        [Route("lastBlock")]
        public ActionResult<Mempool> GetLastBlock()
        {

            var mempool = _mempoolService.GetLastBlock();

            return Ok(mempool);

        }

        /*--------------------------------------------------------*/
        [HttpPost]
        [Route("minado/")]
        public string Minado(Block block)
        {

            minado Logic = new minado();           
          //  while () {
                Thread p1 = new Thread(() => Logic.GetSha256(block));
                p1.Start();
              
            //p1.Abort();
            while (Logic.blockValidate == "Vacio") {
                Thread.Sleep(1000);
            }
            //}

           // p1.Abort();
            return block.ToString();
            
        }


      



    }
}
