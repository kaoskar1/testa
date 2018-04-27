using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_tre_Oskar_Ljungdahl
{
    class Bird : Animal
    {
        public string  WingSpread { get; set; }

        public Bird(int age, string name, double height, double weight, double wingSpread) : base(age, name, height, weight)
        {

            WingSpread = WingSpread;
        }
    }
}
