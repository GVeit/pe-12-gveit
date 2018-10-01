using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy candy = new Candy("green");
            Regular regular = new Regular("purple");
            ColorBomb bomb = new ColorBomb("multicolored");
            Striped striped = new Striped("red");
            Wrapped wrapped = new Wrapped("yellow");

            // Print all candies
            candy.printDisplay();
            regular.printDisplay();
            bomb.printDisplay();
            striped.printDisplay();
            wrapped.printDisplay();
        }
    }
}
