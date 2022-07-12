using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Interfaces
{
    public class IMinadoService : IMinado
    {
        public bool verifyConditionHash(string hash)
        {
            bool state = false;

            if (!hash.Substring(0, 4).Equals("0000")) {
                state = true;
            }

            return state;
        }
    }
}
