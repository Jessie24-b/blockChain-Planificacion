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
    }
}
