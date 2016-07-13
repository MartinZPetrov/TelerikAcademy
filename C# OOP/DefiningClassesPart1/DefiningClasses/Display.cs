using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Display
    {
        private double size;
        private int numberOfColors;


        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }

        // default Values
        public Display() : this(1.5, 255) { }

        public Display(double size) : this(size, 255) { }

        public Display(double size, int colors)
        {
            this.Size = size;
            this.NumberOfColors = colors;
        }



    }
}
