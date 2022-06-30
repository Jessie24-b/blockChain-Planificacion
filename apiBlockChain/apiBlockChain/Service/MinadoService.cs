using apiBlockChain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Service
{
    public class MinadoService
    {

        private IMongoCollection<Block> _minado;

        public MinadoService(IBlockChainSetting setting)
        {

            var cliente = new MongoClient(setting.Server);
            var database = cliente.GetDatabase(setting.Database);
            _minado = database.GetCollection<Block>(setting.MinadoCollection);
        }

        public Block InsertBlock(Block bloq)
        {

            _minado.InsertOne(bloq);

            return bloq;

        }

        public async Task<Block> GetLastBlock()
        {

            try
            {
                List<Block> listBlock = await _minado.Find(d => true).ToListAsync();

                if (listBlock.Count == 0)
                {
                    return null;
                }
                else
                {
                    var prueba= listBlock[listBlock.Count - 1];
                    return prueba;
                }


            }
            catch(Exception e) {
                throw e;
            }
            // var sort = Builders<Mempool>.Sort.Descending("nombre");
            // var limit = sort.limit(1);
            //var data = _mempool.Find(Builders<Mempool>.Filter.Empty).Limit(1).Sort("nombre: -1");

        }
    }
}
