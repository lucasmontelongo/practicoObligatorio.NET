using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Shared.Entities;

namespace ServiceLayer
{
    public class ServiceEmployeeProxy :
        ClientBase<IServiceEmployees>,
        IServiceEmployees
    {

        public void AddEmployee(Employee emp)
        {
            base.Channel.AddEmployee(emp);
        }

        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            return base.Channel.CalcPartTimeEmployeeSalary(idEmployee, hours);
        }

        public void DeleteEmployee(int id)
        {
            base.Channel.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return base.Channel.GetAllEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return base.Channel.GetEmployee(id);
        }

        public void UpdateEmployee(Employee emp)
        {
            base.Channel.UpdateEmployee(emp);
        }
    }
}
