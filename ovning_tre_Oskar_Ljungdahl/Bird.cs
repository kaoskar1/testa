using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_tre_Oskar_Ljungdahl
{
    class Bird : Animal
    {
        public Bird(int age, string name, double height, double weight) : base(age, name, height, weight)
        {
            var bird = new Bird(123, "Polly", 32, 22);
            
        }
    }
}
