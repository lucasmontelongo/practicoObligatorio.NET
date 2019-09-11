using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Exception
{
    public class TypePartTimeEmployeeException : SystemException
    {
        public TypePartTimeEmployeeException() 
            : base("El empleado indicado es de tipo PartTime")
        {

        }
    }
}
