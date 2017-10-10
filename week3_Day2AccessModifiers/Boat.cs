using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_Day2AccessModifiers
{
    class Boat
    {
        //these look like variables, but they are FIELDS (90% of time FIELDS ARE PRIVATE)
        //fields are characteristics or class information
        //information about the specific instance
        public int numberOfPassengers;
        
        private string name;
        private double engineSize;


        //this is the Property - used to expose private fields
        //PROPERTIES ARE PUBLIC SO THAT DATA CAN BE UTILIZED
        //Property Advantage - can hide where information is stored(good for storing passwords)
        public string Name
        {
            get { return name; }//get = 
            set { name = value; }//set = 
        }

        //This is the Default Constructor
        //has Enpty ()
        //Constructors are used to Create Something
        //The Default Constructor Does Not have to be used
        //All Constructors Initialize an Object
        //CONSTRUCTORS HAVE TO BE PUBLIC SO THEY CAN BE CALLED
        public Boat()
        {

        }

        //adding A New Constructor
        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            //these are the instance variables
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }


        //Move and Calculate Are Methods
        //Move Will not Reurn a Value
        //Move Can Be accessed Anywhere
        public void Move()
        {
            Console.WriteLine(name + " moves forward.");
            //code to make the boat move
        }


        //Calculate Can only be accessed within this Class
        private double CalculateMPG()
        {
            //code to calsulate the MPG - example calculation
            double MPG = engineSize * .7d;
            return MPG; 
        }

        //MAKING A METHOD TO USE THE MPG METHOD
        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine Size: " + engineSize);
            //Method within a Method & The method is Private
            Console.WriteLine("MPG: " + CalculateMPG());
            Console.WriteLine();//adds blank line
        }
    }
}
