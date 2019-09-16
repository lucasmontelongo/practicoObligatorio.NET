using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLayer.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }
        public double HourlyRate { get; set; }
        public string TypeEmp { get; set; }
    }
}