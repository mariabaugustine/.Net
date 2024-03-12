using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileManagement
{
    internal class MobileException
    {
        public void MException(Mobile mobile)
        {
            if (string.IsNullOrEmpty(mobile.Name))
            {
                throw new MobileValidation("Name field cannot be null or empty");

            }
            if (string.IsNullOrEmpty(mobile.Description))
            {
                throw new MobileValidation("**********Description field cannot be null or empty**********");

            }
            if (string.IsNullOrEmpty(mobile.ManufacturedBy))
            {
                throw new MobileValidation("**********ManufacturedBy field cannot be null or empty**********");

            }
            if (mobile.price <= 0)
            {
                throw new MobileValidation("**********Price must be greater than zero*************");
            }
        }

    }
    internal class MobileValidation:Exception

    {
        public MobileValidation(String message):base(message)
        { }
    }
}
