using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12
{
    class Candy
    {
        protected string color;
        protected int numOfCandies;
        protected string specialPower;
        protected string make;

        // Color 
        public void setColor(string _color)
        {
            color = _color;
        }

        public string getColor()
        {
            return color;
        }

        // Number of Candies
        public void setNum(int _num)
        {
            numOfCandies = _num;
        }

        public int getNum()
        {
            return numOfCandies;
        }

        // Special Power
        public void setPower(string _power)
        {
            specialPower = _power;
        }

        public string getPower()
        {
            return specialPower;
        }

        public Candy(string _color)
        {
            setColor(_color);
            numOfCandies = 0;
            specialPower = "Match 3 of these candies in a row to earn points!";

            make = "Make a "+getColor()+" candy\n";
        }

        public Candy()
        {
          
        }

        
        public void printDisplay()
        {
            Console.WriteLine(make+"The {0} candy requires {1} matched candies to spawn.\n{2}’s special power: {3}\n", getColor(), getNum(), getColor(), getPower());
        }
        

    }
}
