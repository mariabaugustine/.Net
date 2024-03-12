using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeExample
{
    
        [AttributeUsage(AttributeTargets.All)]
        public class MyAttribute : Attribute
        {

            private string name;

            
            private string action;

          
            public MyAttribute(string name, string action)
            {
                this.name = name;
                this.action = action;
            }

            public string Name
            {
                get { return name; }
            }

          
            public string Action
            {
                get { return action; }
            }
        }

    }

