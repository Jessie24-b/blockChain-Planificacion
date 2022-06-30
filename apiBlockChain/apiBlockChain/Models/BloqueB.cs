using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Models
{
    public class BloqueB
    {
       
        public BloqueB(int _idBloque,string _fechaMinado,int _prueba,int _milisegundos) {

            idBloque = _idBloque;
            fechaMinado = _fechaMinado;
            prueba = _prueba;
            milisegundos = _milisegundos;

        }
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("idBloque")]
        public int idBloque { get; set; }

        [BsonElement("fechaMinado")]
        public string fechaMinado { get; set; }

        [BsonElement("prueba")]
        public int prueba { get; set; }

        [BsonElement("milisegundos")]
        public int milisegundos { get; set; }

        [BsonElement("documentos")]
        public string [] documentos { get; set; }

        [BsonElement("hashPrevio")]
        public string hashPrevio { get; set; }

        [BsonElement("hash")]
        public string hash { get; set; }


    }
}
