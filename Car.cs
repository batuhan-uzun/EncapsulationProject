using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProject
{
    internal class Car
    {
        public string Brand { get; set; } // Assigned brand, model, color and number of doors properties
        public string Model { get; set; }
        public string Color { get; set; }

        private int _numberOfDoors; // Created a variable with private int for encapsulation
        public int NumberOfDoors
        {
            get { return _numberOfDoors; } 
            set
            {
                if (value == 2 || value == 4) // Logical control for the number of doors to be 2 or 4
                    _numberOfDoors = value;
                else
                {
                    _numberOfDoors = -1;
                    Console.WriteLine("Kapı sayısı 2 veya 4 olabilir!");
                }
                    
            }
        }
    }
}
