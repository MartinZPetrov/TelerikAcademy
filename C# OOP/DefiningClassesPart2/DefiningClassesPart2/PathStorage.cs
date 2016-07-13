using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static class PathStorage //problem4
    {
        public static void SavePath(Path path, string pathIdentifier) //saves the file in the main project directory
        {                                                             //where all the .cs files are
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathIdentifier + ".txt"))
            {
                for (int i = 0; i < path.PathList.Count; i++)
                {
                    sw.WriteLine(path.PathList[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }



    }
}
