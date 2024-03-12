using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    class Student
    {

       
        private int rollNo;
        private string stuName;
        private double marks;

     
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int rollNumber,string studentName, double mark)
        {
            rollNo = rollNumber;
            stuName = studentName;
            marks = mark;
        }

        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStudentName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }
}

