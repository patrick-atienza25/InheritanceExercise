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

        public string TongueKind { get; set; }
        public string Grow { get; set; }
        public string FavoriteFood { get; set; }
        public string Movement { get; set; }

        public void PrintMembers()
        {
            Console.WriteLine($"Komodo dragons have {TongueKind} tongues.");
            Console.WriteLine($"As komodo dragons get bigger they begin to {Grow}.");
            Console.WriteLine($"Komodo dragons favorite food is {FavoriteFood}");
            Console.WriteLine($"Komodo dragons don't walk, they {Movement}");
        }

    }
}
