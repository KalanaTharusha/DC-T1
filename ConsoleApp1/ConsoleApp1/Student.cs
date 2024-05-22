using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Student: Person
    {
        private int id;
        private string university;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public override string ToString()
        {
            string info = "The student's name is " + Name +
                "\nThe student's id is " + Id +
                "\nThe student's university is " + University;
            return info;
        }
    }
}
