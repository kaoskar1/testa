using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_tre_Oskar_Ljungdahl
{
    class Dog : Animal
    {
        public string Race { get; set; }
        public Dog(int age, string name, double height, double weight, string race) : base(age, name, height, weight)
        {
            Race = race;
            
        }

        
    }
    }

