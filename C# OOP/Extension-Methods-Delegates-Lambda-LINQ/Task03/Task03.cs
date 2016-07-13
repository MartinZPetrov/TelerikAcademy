using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    //Use LINQ query operators.
    class Task03
    {
        static void Main(string[] args)
        {

            Students[] std = {   new Students("Ivan", "Petrov", 19),
                                new Students("Atanas", "Georgiev", 44 ),
                                new Students("Georgi", "Atanassov",43 ),
                                new Students("Stamat", "Dimitrov",22),
                                new Students("Pesho", "Todorov",1),
                                new Students("Pesho", "Ivanov",12),
                                new Students("Pesho", "Peshev",30),
                                new Students("Pesho", "Andreev",31)};

            var res = FirstBeforeLast(std);

            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName + item.SecondName);
            }

            res = Between18and24(std);
            Console.WriteLine("-------------------------");
            foreach (var item in res)
            {
                Console.WriteLine(item.Age);
            }

            res = SortDesecning(std);
            Console.WriteLine("-------------------------");
            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName + " " + item.SecondName);
            }

        }

        //03
        private static IEnumerable<Students> FirstBeforeLast(Students[] std)
        {
            IEnumerable<Students> result =
                        from student in std
                        where student.FirstName.CompareTo(student.SecondName) < 0
                        select student;

            return result;
        }

        //04 Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        private static IEnumerable<Students> Between18and24(Students[] std)
        {
            IEnumerable<Students> result =
                        from student in std
                        where student.Age >= 18 && student.Age <= 24
                        select student;

            return result;
        }

        //05
        //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
        //Rewrite the same with LINQ.
        private static IEnumerable<Students> SortDesecning(Students[] std)
        {

            //var result = std.OrderByDescending(e => e.FirstName).ThenByDescending(e => e.SecondName);
            
            var result =
            from student in std
            orderby student.FirstName descending, student.SecondName descending
            select student;

            return result;
        }


    }
}
