﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEXception
{
    internal class Custom:Exception
    {
        public override string Message
        {
            get
            {
                return "Odd numbers are not allowed";
            }
        }
    }
}
