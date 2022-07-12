using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiBlockChain.Models;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using apiBlockChain.Interfaces;

namespace apiBlockChain.LogicB
{
    public class LogicMinado
    {
        public BloqueB bloque;

       public IMinadoService iMinadoService = new IMinadoService();
      

       

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

        public string generateFechaHora()
        {
         
           string localDate= DateTime.Now.ToString("yyyyMMddTHHmmss");


            return localDate;
        }

        public Block getBlock(Block b)
        {
            string documentos = GenerateHash256(b.ConvertListToString());
            string hash;
            int interval = 1000;
            var sw = Stopwatch.StartNew();
            int prueba = 0;
           
            string fechaMinado;
            string milisegundos = "";

            do
            {



                
                fechaMinado = generateFechaHora();
                milisegundos = (sw.ElapsedMilliseconds).ToString();


                crearBloque(b,fechaMinado,milisegundos,prueba);

                
                hash = GenerateHash256(b.ToString()+documentos);
               
                if (sw.ElapsedMilliseconds == interval)
                {
                    prueba = 0;
                    sw.Reset();
                    sw.Start();
                }
                else
                {
                    prueba++;
                }



            } while (iMinadoService.verifyConditionHash(hash));
            sw.Stop();

            b.Hash = hash;
            
            return b;



        }

        public Block crearBloque(Block b,string fechaMinado,string milisegundos,int prueba) {

            b.Milisegundos = milisegundos;
            b.FechaMinado = fechaMinado.ToString();
            b.Prueba = prueba;

            return b;
        }







    }


}


