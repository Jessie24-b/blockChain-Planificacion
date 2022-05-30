using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBlockChain.Models;
using MongoDB.Driver;



namespace apiBlockChain.Service
{
    public class MempoolService
    {
        private IMongoCollection<Mempool> _mempool;

        public MempoolService(IBlockChainSetting setting)
        {

            var cliente = new MongoClient(setting.Server);
            var database = cliente.GetDatabase(setting.Database);
            _mempool = database.GetCollection<Mempool>(setting.MempoolCollection);
        }


        public Mempool InsertMempool(Mempool mempool)
        {

            _mempool.InsertOne(mempool);

            return mempool;

        }
    }
}
