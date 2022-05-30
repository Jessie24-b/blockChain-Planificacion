using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace apiBlockChain.Models
{
    public class Mempool
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("archivo")]
        public string Archivo { get; set; }

        [BsonElement("propietario")]
        public string Propietario { get; set; }

        [BsonElement("tipoArchivo")]
        public string TipoArchivo { get; set; }

        [BsonElement("fecha")]
        public string Fecha { get; set; }

        [BsonElement("tamanio")]
        public string Tamanio { get; set; }

    }
}
