using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
    //Use LINQ.
    public class Grouping
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Ivan","Math"),
                new Student("Petar", "Comupter Science"),
                new Student("Firo", "Math"),
                new Student("Miro", "Biology"),
                new Student("Kiro", "Sports")
            };

            //var grouped = students.OrderBy(x => x.Group);     //problem 18 expression

            var grouped = ExtensionMethodGrouping.ExtensionGrouping(students);      //problem 19 impelentation

            foreach (var st in grouped)
            {
                Console.WriteLine(st.ToString());
            }
        }
    }
}
