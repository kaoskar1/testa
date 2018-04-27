using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_tre_Oskar_Ljungdahl
{
    class Cat : Animal
    {

        public string Color { get; set; }
        public string Sounds { get; set; }


        public Cat(int age, string name, double height, double weight, string color, string sounds) : base(age, name, height, weight)
        {

            Color = color;
            Sounds = sounds;
        }
    }
}
