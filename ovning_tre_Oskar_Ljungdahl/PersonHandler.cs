using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovning_tre_Oskar_Ljungdahl
{
    class PersonHandler : Person
    {

        public Person CreatePerson(int age, string fname,
       string lname, double height, double weight)
       {
           
            var gh = new Person();
            age = 20;
            fname = "A";
            lname = "Bson";
            height = 1.78;
            weight = 23.2;

            return gh;
        }
        


        public void SetAge(Person pers, int age)
        {
            var person = new Person();
            person.Age = 20;
        }
        
        

    }
   

}

