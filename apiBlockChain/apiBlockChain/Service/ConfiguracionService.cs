using apiBlockChain.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Service
{
    public class ConfiguracionService
    {
        private IMongoCollection<Configuracion> _configuracion;

        public ConfiguracionService(IBlockChainSetting setting) {

            var cliente = new MongoClient(setting.Server);
            var database = cliente.GetDatabase(setting.Database);
            _configuracion= database.GetCollection<Configuracion>(setting.Collection);
        }

        public async Task<List<Configuracion>> GetList()
        {
            var data = await _configuracion.FindAsync(d => true).Result.ToListAsync();

            return data;
        }

        public Configuracion InsertConfiguracion(Configuracion configuracion)
        {

            _configuracion.InsertOne(configuracion);

            return configuracion;

        }

    }
}
