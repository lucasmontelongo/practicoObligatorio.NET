using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Exception
{
    public class TypeFullTimeEmployeeException : SystemException
    {
        public TypeFullTimeEmployeeException() 
            : base("El empleado indicado es de tipo FullTime")
        {

        }
    }
}
