using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    internal class Student
    {
        public string Name;
        public string Major;
        public double GPA;

        public Student(string aName, string aMajor, double aGPA)
        {
            Name = aName;
            Major = aMajor;
            GPA = aGPA;
        }

        public string HasHonors()
        {
            if(GPA >= 3.5)
            {
                string result = "does have honors.";
                return result;
                
            }
            else
            {
                string result = "does not have honors.";
                return result;
                
            }
        }

    }
}
