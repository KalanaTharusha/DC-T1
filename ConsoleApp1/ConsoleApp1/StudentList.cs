using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentList
    {
        public static List<Student> Students()
        {
            List<Student> sList = new List<Student>();

            Student s1 = new Student();
            s1.Name = "Kalana";
            s1.Id = 1;
            s1.University = "Curtin University";

            Student s2 = new Student();
            s2.Name = "Robert";
            s2.Id = 2;
            s2.University = "EWU";

            Student s3 = new Student();
            s3.Name = "James";
            s3.Id = 3;
            s3.University = "Murdoch";

            Student s4 = new Student();
            s4.Name = "Sarah";
            s4.Id = 4;
            s4.University = "University of Melbourne";

            Student s5 = new Student();
            s5.Name = "Michael";
            s5.Id = 5;
            s5.University = "Stanford University";

            Student s6 = new Student();
            s6.Name = "Emily";
            s6.Id = 6;
            s6.University = "Harvard University";

            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);
            sList.Add(s5);
            sList.Add(s6);

            return sList;
        }
    }
}
