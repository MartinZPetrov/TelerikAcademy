using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    public static class SbExtended
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            var result = new StringBuilder();

            for (int position = 0; position < length; position++)
            {
                result.Append(sb[index + position]);
            }
            return result;
        }    
    }
}
