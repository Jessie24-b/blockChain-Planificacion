using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace apiBlockChain.Models
{
    public class Block
    {

        public Block(int _idBloque, string _fechaMinado, int _prueba, string _milisegundos,string _archivos
            ,string _hashPrevio,string _hash)
        {

            IdBloque = _idBloque;
            FechaMinado = _fechaMinado;
            Prueba = _prueba;
            Milisegundos = _milisegundos;
            Archivos = _archivos;
            HashPrevio = _hashPrevio;
            Hash = _hash;

        }
        public Block() { 
        }

        /*[BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string  Id { get; set; }*/

        [BsonElement("idBloque")]
        public int IdBloque { get; set; }

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
            return IdBloque+FechaMinado+Prueba+Milisegundos+Archivos+HashPrevio+Hash;
        }


    }

    
}
