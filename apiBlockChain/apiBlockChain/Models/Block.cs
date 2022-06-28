using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace apiBlockChain.Models
{
    public class Block
    {
        

        
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string  Id { get; set; }

        [BsonElement("fechaMinado")]
        public string FechaMinado { get; set; }

        [BsonElement("prueba")]
        public int Prueba { get; set; }

        [BsonElement("milisegundos")]
        public string Milisegundos { get; set; }

        [BsonElement("archivos")]
        public string Archivos { get; set; }

        [BsonElement("hashPrevio")]
        public string HashPrevio { get; set; }

        [BsonElement("hash")]
        public string Hash { get; set; }


        public override string ToString()
        {
            return "FechaMinado: "+FechaMinado + "Prueba: "+ Prueba+ "Milisegundos: "+ Milisegundos+
                "Archivos: "+ Archivos+ "hashPrevio: "+ HashPrevio+ "Hash: "+ Hash;
        }


    }

    
}
