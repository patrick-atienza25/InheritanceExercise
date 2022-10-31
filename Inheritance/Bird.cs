using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animals
    {
        public Bird()
        {
        }
        public bool HasFeathers { get; set; }
        public bool CanFly { get; set; }
        public bool IsColorful { get; set; }
        public bool LaysEggs { get; set; }

    }
}
