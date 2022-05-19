using apiBlockChain.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Service
{
    public class UsuarioService
    {
        private IMongoCollection<Usuario> _usuario;


        public UsuarioService(IBlockChainSetting setting)
        {

            var cliente = new MongoClient(setting.Server);
            var database = cliente.GetDatabase(setting.Database);
            _usuario = database.GetCollection<Usuario>(setting.Collection);
        }

        public async Task<List<Usuario>> GetList()
        {
           var data = await _usuario.FindAsync(d => true).Result.ToListAsync();

            return data;
        }

        public Usuario GetUsuario(string user, string password)
        {
            var filter = Builders<Usuario>.Filter.Eq(Usuario=>Usuario.User, user);
            var data = _usuario.Find(filter).FirstOrDefault();

            return data;
        }

        public Usuario InsertUsuario(Usuario usuario)
        {

            _usuario.InsertOne(usuario);

            return usuario;

        }
    }
}
