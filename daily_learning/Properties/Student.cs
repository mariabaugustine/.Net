using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Student
    {
        private int id;
        private string name;
        private int passmark;
        public int StudentId
        {
            get
            {
                return id; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("value must be greater than 0");
                }
            id = value;
            }
        }
        public int PassMark
        {
            get
            { 
                return passmark;    
            }
        }
        public string StudentName
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null");
                }
                else if (!value.StartsWith("p"))
                {
                    throw new Exception("Name should be start with p");
                }
                else
                {
                    name = value;
                }


                }

            }
        }

    }

