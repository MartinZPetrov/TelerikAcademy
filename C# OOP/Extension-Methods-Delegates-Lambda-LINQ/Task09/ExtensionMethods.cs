using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    public static class ExtensionMethods
    {

        public static IEnumerable<Students> GetFromSecondGroupSorted(this IEnumerable<Students> std)
        {
            var result = from item in std
                         where item.GroupNumber == 2
                         orderby item.FirstName
                         select item;

            return result;
        }

        //problem 11
        public static IEnumerable<Students> SortByEmail(this IEnumerable<Students> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Email.Contains("abv.bg")
                select st;

            return sorted;

        }


        public static  IEnumerable<Students>  SortByPhoneInSofia(this IEnumerable<Students> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.PhoneNumber.StartsWith("02")
                select st;

            return sorted;
        }

        public static void GetExcellent(this IEnumerable<Students> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Marks.Contains(6)
                select new { Name = st.FirstName, Marks = st.Marks };

            foreach (var item in sorted)
            {
                Console.WriteLine(item.Name + " " + "[" + string.Join(",", item.Marks) + "]");
            }
        }

        public static IEnumerable<Students> ExtensionSortByAtleastTwoMarks(this IEnumerable<Students> studentsGroup)
        {
            var sorted =
                from st in studentsGroup
                where st.Marks.Count == 2
                select st;

            return sorted;
        }


        //problem 16*
        public static void SortByMathematicsDepartment(IEnumerable<Students> studentsGroup, IEnumerable<Group> groups)
        {
            var sorted =
                from st in studentsGroup
                join gr in groups on st.GroupNumber equals gr.GroupNumber
                where gr.GroupNumber == 10
                select st;


            foreach (var item in sorted)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine("Students from Mathematics Department");

        }
    }
}
