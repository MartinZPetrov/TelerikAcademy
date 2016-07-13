using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    public class Students
    {
        private string firstName;
        private string lastName;
        private string fN;
        private string phoneNumber;
        private string email;
        private List<int> marks;
        private int groupNumber;


        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }
        public List<int> Marks
        {
            get { return new List<int>(this.marks); }
            private set { this.marks = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string FN
        {
            get { return fN; }
            set { fN = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Group Group { get; private set; }

        public Students(string firstName, string lastName, string fN,
           string phoneNumber, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }




    }
}

