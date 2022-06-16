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

        public async Task<List<Mempool>> GetListMempool()
        {
            var data = await _mempool.FindAsync(d => true).Result.ToListAsync();

            return data;
        }

        public void DeleteMempool(string id)
        {
            _mempool.DeleteOne(d => d.Id == id);

        }

        public Mempool GetFile(string id)
        {
            var filter = Builders<Mempool>.Filter.Eq(Mempool => Mempool.Id, id);
            var data = _mempool.Find(filter).FirstOrDefault();

            return data;

        }

    }
}
