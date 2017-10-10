using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_Day2AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new Instance with the Constructor with 3 arguments
            Boat Luca = new Boat(3, "Luca", 18.6);
            Luca.Move();


            //eventhough the Methos was created, C# does not recognize this
            //its private and the program does not recognize it
            //Luca.CalculateMPG();

            Luca.BoatInfo();

            //creating a new instance
            Boat boat2 = new Boat(14, "Pedro", 30.8);
            boat2.BoatInfo();
        }
    }
}
