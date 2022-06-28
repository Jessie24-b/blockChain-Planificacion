using apiBlockChain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace apiBlockChain.Logic
{
    public class minado 
    {
        public string blockValidate = "Vacio";

        public void GetSha256(Block block)
        {
             
           
             Boolean stop = true;
           
            while (stop) {
                block.FechaMinado = DateTime.Now.ToString("yyyyMMddHHmmss.fff");
                StringBuilder sb = new StringBuilder();
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream;
                stream = sha256.ComputeHash(encoding.GetBytes(block.ToString()));

                for (int i = 0; i < stream.Length; i++)
                {
                    Console.WriteLine(stream[i]);
                    sb.AppendFormat("{0:x2}", stream[i]);
                }

               
                if (sb.ToString().Substring(0, 4) == "0000")
                {
                    stop = false;
                    this.blockValidate = sb.ToString();
                }
                else {
                    block.Prueba++;
                }
            }




           

        }


    }
}
