using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public static class EnumerableExtensions
    {

        public static  T Sum<T>(this IEnumerable<T> collection) where T : IComparable
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
           
        }


        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T product = (dynamic)1;
            return collection.Aggregate(product, (acc, val) => acc * (dynamic)val);
        }


        public static T Avarage<T>(this IEnumerable<T> collection) where T : IComparable
        {
            double sum = 0.0d;
            return (dynamic)collection.Aggregate(sum, (acc, val) => acc + (dynamic)val / (dynamic)collection.Count()); 
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(min) < 0)
                    min = element;
            return min;
        }


        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.First();
            foreach (var element in collection)
                if (element.CompareTo(min) > 0)
                    min = element;
            return min;
        }

    }
}
