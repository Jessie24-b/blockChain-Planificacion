using apiBlockChain.Models;
using apiBlockChain.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using apiBlockChain.Logic;
using apiBlockChain.LogicB;

namespace apiBlockChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MempoolController : Controller
    {

        public MempoolService _mempoolService;
        public MinadoService _minadoService;
        public LogicMinado logM;

        public MempoolController(MempoolService mempoolService, MinadoService minadoService)
        {


            _mempoolService = mempoolService;
            _minadoService = minadoService;
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


      
        [HttpPost]
        [Route("minado/")]
        public ActionResult<Block> Minado(Block block)
        {
            LogicMinado log = new LogicMinado();

             block=log.getBlock(block);

            _minadoService.InsertBlock(block);
           
             return Ok(block); 
                   
        }

       








    }
}
