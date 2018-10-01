using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{


    class Regular : Candy
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

        public Regular(string _color)
        {
            setColor(_color);
            numOfCandies = 0;
            specialPower = "It does not have a special power";

            coolnessLevel = 5;

            make = "Make a "+getColor()+" candy\n";

        }

        public void printDisplay()
        {
            Console.WriteLine(make+"\nThe {0} candy requires {1} matched candies to spawn.\n{2}’s special power: {3}\n", getColor(), getNum(), getColor(), specialPower);

            Console.WriteLine("The {0} candy is a regular candy.\n{1}, so its coolness is {2}.\n", getColor(), getPower(), coolnessLevel);

            Console.WriteLine("\n______________________________________________________________________________________\n");
        }

    }
}
