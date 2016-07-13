using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public struct Point3D
    {
        private static readonly Point3D O;

        private double x; //problem 1
        private double y; //problem 1
        private double z; //problem 1

        public double X //problem 1
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y //problem 1
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z //problem 1
        {
            get { return this.z; }
            private set { this.z = value; }
        }


        public static Point3D GetPoint
        {
            get { return O; }
        }

        static Point3D()
        {
            O = new Point3D(0, 0, 0);
        }

        public Point3D(double xCoord, double yCoord, double zCoord) : this()
        {
            this.X = xCoord;
            this.Y = yCoord;
            this.Z = zCoord;
        }


        public override string ToString() //problem 1
        {
            return string.Format("X = {0}; Y = {1}; Z = {2}", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
