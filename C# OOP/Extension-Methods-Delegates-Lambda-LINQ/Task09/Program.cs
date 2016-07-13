using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task09;


//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.
namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Students>(new[] { new Students("martin", "petrov", "351006", "77777", "abv@abv.bg", new List<int>(new[] { 1, 2, 6 }), 2), 
                                                  new Students("gosho", "stoyanbov", "1234", "77777", "yahoo@yahoo.bg", new List<int>(new[] { 1, 6, 6 }), 10),
                                                  new Students("stamat", "gavrialov", "025116778", "025116778", "abv@abv.bg", new List<int>(new[] {  2, 3 }), 2) 
                                                });


            List<Group> groups = new List<Group>()
            {
                new Group(2, "Computer Science"),
                new Group(10, "Mathematics")
            };


            //09 
            var result = from std in list
                         where std.GroupNumber == 2
                         orderby std.FirstName
                         select std;

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName);
            }
            //10 Implement the previous using the same query expressed with extension methods.

            var res = list.GetFromSecondGroupSorted();

            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName);
            }

            //11 tract all students that have email in abv.bg.
            //Use string methods and LINQ.
            res = list.SortByEmail();
            foreach (var item in res)
            {
                Console.WriteLine(item.Email);
            }


            //12 Extract all students with phones in Sofia.
            //Use LINQ.
            res = list.SortByPhoneInSofia();
            foreach (var item in res)
            {
                Console.WriteLine(item.PhoneNumber);
            }

            //13 Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.
            list.GetExcellent();


            //14 Write down a similar program that extracts the students with exactly two marks "2".
            res = list.ExtensionSortByAtleastTwoMarks();
            foreach (var item in res)
            {
                Console.WriteLine(item.FirstName);
            }

            SortBySigningIn2006(list);


            ExtensionMethods.SortByMathematicsDepartment(list,groups);


        }

        public static void SortBySigningIn2006(IEnumerable<Students> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.FN.EndsWith("06")
                select st;

            Console.WriteLine("Marks of students enrolled in 2006");

            foreach (Students student in sorted)
            {
                Console.WriteLine(student.FirstName +
                    "[" + string.Join(", ", student.Marks) + "]");
            }
            Console.WriteLine();
        }

    }
}
