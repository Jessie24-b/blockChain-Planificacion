using apiBlockChain.Models;
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

        public List<Usuario> GetList()
        {
           var data = _usuario.Find(d => true).ToList();

            return data;
        }


        public Usuario InsertUsuario(Usuario usuario)
        {

            _usuario.InsertOne(usuario);

            return usuario;

        }
    }
}
