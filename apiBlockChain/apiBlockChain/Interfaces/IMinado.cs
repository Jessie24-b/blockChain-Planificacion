using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Interfaces
{
    interface IMinado
    {

       public Boolean verifyConditionHash(string hash);
    }
}
