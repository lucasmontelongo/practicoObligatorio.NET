using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class EmployeeAPIRest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }
        public double HourlyRate { get; set; }
        public string TypeEmp { get; set; }
    }
}
