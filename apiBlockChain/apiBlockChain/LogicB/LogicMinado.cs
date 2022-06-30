using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBlockChain.Models;
using System.Security.Cryptography;
using System.Text;

namespace apiBlockChain.LogicB
{
    public class LogicMinado
    {
        public BloqueB bloque;
        public LogicMinado(BloqueB _bloque)
        {
         
          
        }

        public LogicMinado()
        {
        }

        public string GenerateHash256(string text) {

            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(text));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public DateTime generateFechaHora() {
            DateTime localDate = DateTime.Now;
            localDate.ToString("en-GB");
            string datetime = DateTime.Now.ToString("hh:mm:ss tt");
            
            return localDate;
        }

        public long generateDateToInt(DateTime fechaMinado) {
            DateTime centuryBegin = new DateTime(2001, 1, 1);
            return (fechaMinado.Ticks - centuryBegin.Ticks);
           
        }

        public string generateHash(string sha256) {

            GenerateHash256(sha256);

            return "";
        }

  

    }


}


