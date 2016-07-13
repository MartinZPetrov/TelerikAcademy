using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    
    public class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public int Age { get; set; }

        public Students(string firstname, string secondname , int age)
        {
            FirstName = firstname;
            SecondName = secondname;
            Age = age;
        }
    }
}
