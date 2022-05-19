using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Models
{
    public class Configuracion
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }


        [BsonElement("key")]
        public string Key { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }
    }
}
