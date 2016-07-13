using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    public static class ExtensionMethodGrouping
    {
        public static IEnumerable<Student> ExtensionGrouping(this IEnumerable<Student> groups)
        {
            return groups.OrderBy(x => x.Group);
        }
    }
}
