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
        public string LivesWhere { get; set; }
        public string Color { get; set; }
        public string FavoriteFood { get; set; }
        public int HowManyWings { get; set; }

        public void PrintMembers()
        {
            Console.WriteLine($"Toucans favorite food is {FavoriteFood}!");
            Console.WriteLine($"Most toucans are colored {Color}.");
            Console.WriteLine($"Toucans have {HowManyWings} wings.");
            Console.WriteLine($"Toucans live mainly in {LivesWhere}.");
        }
    }
}
