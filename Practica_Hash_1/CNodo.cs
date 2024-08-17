using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Hash_1
{
    public class CNodo
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public CNodo Siguiente { get; set; }

        public CNodo(int key, string value)
        {
            Key = key;
            Value = value;
            Siguiente = null;
        }
    }
}
