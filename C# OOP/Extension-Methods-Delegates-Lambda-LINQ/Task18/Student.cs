using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    public class Student
    {
        private string name;
        private string group;

        public Student(string name, string group)
        {
            this.Name = name;
            this.Group = group;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group name cannot be empty");
                }

                this.name = value;
            }
        }
        public string Group
        {
            get { return this.group; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group name cannot be empty");
                }

                this.group = value;
            }
        }

        public override string ToString()
        {
            return this.Name + ": " + this.Group;
        }

    }
}
