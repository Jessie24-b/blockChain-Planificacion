using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiBlockChain.Models
{
    public class BlockChainSetting : IBlockChainSetting
    {

        public string Server { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
        public string CollectionConfig { get; set; }
        public string MempoolCollection { get; set; }
    }

    public interface IBlockChainSetting
    {

        string Server { get; set; }
        string Database { get; set; }
        string Collection { get; set; }
        public string CollectionConfig { get; set; }
        public string MempoolCollection { get; set; }
    }
}
