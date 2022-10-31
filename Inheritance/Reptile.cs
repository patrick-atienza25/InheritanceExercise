using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animals
    {
        public Reptile()
        {
        }

        public bool IsColdBlooded { get; set; }
        public bool Sheds { get; set; }
        public bool EatsFlies { get; set; }
        public bool HasSpikes { get; set; }

    }
}
