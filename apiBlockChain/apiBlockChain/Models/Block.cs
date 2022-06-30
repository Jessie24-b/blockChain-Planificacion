using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace apiBlockChain.Models
{
    public class Block
    {

        public Block() { 
        }

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string  Id { get; set; }

        [BsonElement("idBloque")]
        public int IdBloque { get; set; }

        [BsonElement("fechaMinado")]
        public string FechaMinado { get; set; }

        [BsonElement("prueba")]
        public int Prueba { get; set; }

        [BsonElement("milisegundos")]
        public string Milisegundos { get; set; }

        [BsonElement("archivos")]
        public List<string> Archivos { get; set; }

        [BsonElement("hashPrevio")]
        public string HashPrevio { get; set; }

        [BsonElement("hash")]
        public string Hash { get; set; }


        public override string ToString()
        {
            return IdBloque+FechaMinado+Prueba+Milisegundos+HashPrevio;
        }

        public string ConvertListToString() {
            List<string> list = Archivos;
            char delim = ',';

            string str = String.Join(delim, list);

            return str;
        }


    }

    
}
