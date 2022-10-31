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
        public string FavoriteFood { get; set; }
        public bool HasScales { get; set; } = true;

        public void PrintMembers()
        {
            Console.WriteLine($"True or false: All reptiles are cold blooded. Answer: {IsColdBlooded}.");
            Console.WriteLine($"True or false: Komodo dragons shed. Answer: {Sheds}.");
            Console.WriteLine($"Komodo dragons favorite food is {FavoriteFood}");
            Console.WriteLine($"True or false: Komodo dragons have scales. Answer: {HasScales}");
        }

    }
}
