using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class ColorBomb : Candy
    {
        private int coolnessLevel;
        private string make;

        // Coolness Level 
        public void setCool(int _cool)
        {
            coolnessLevel = _cool;
        }

        public int getCool()
        {
            return coolnessLevel;
        }

        public ColorBomb(string _color)
        {
            setColor(_color);
            numOfCandies = 5;
            specialPower = "Removes all candies of the same color.";

            coolnessLevel = 10;

            make = "Make a " + getColor() + " candy\n";

            //Console.WriteLine("The {0} candy is a regular candy. It does not have a special power, so its coolness is {1}", color, coolnessLevel);
        }

        public void printDisplay()
        {
            //Console.WriteLine("The {0} candy requires {1} matched candies to spawn.\n{2}’s special power: {3}\n", getColor(), getNum(), getColor(), getPower());

            Console.WriteLine(make+"\nThe {0} candy requires {1} matched candies to spawn.\n{2}'s special power: {3}\n", getColor(), getNum(), getColor(), getPower());
            Console.WriteLine("The {0} candy is a Color Bomb candy.\nIts special power is awesome, so its coolness is {1}.\n", getColor(), coolnessLevel);
            Console.WriteLine("\n______________________________________________________________________________________\n");
        }
    }
}
