using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesEF : IDALEmployees
    {
        public void AddEmployee(Employee emp)
        {
            using (Model.PracticoObligatorioEntities en = new Model.PracticoObligatorioEntities())
            {
                if(emp.GetType().Name == "FullTimeEmployee")
                {
                    FullTimeEmployee employee = (FullTimeEmployee)emp;
                    Model.FullTimeEmployee employeeBase = new Model.FullTimeEmployee()
                    {
                        Name = employee.Name,
                        StartDate = employee.StartDate,
                        Salary = employee.Salary
                    };
                    en.EmployeesTPH.Add(employeeBase);
                    en.SaveChanges();
                }
                else
                {
                    PartTimeEmployee employee = (PartTimeEmployee)emp;
                    Model.PartTimeEmployee employeeBase = new Model.PartTimeEmployee()
                    {
                        Name = employee.Name,
                        StartDate = employee.StartDate,
                        HourlyRate = employee.HourlyRate
                    };
                    en.EmployeesTPH.Add(employeeBase);
                    en.SaveChanges();
                }
            }
        }

        public void DeleteEmployee(int id)
        {
            using (Model.PracticoObligatorioEntities en = new Model.PracticoObligatorioEntities())
            {
                en.EmployeesTPH.Remove(en.EmployeesTPH.Find(id));
                en.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            using (Model.PracticoObligatorioEntities en = new Model.PracticoObligatorioEntities())
            {
                if(emp.GetType().Name == "FullTimeEmployee")
                {
                    FullTimeEmployee empleado = (FullTimeEmployee)emp;
                    Model.FullTimeEmployee empleadoBase = (Model.FullTimeEmployee)en.EmployeesTPH.Find(emp.Id);
                    empleadoBase.Name = empleado.Name;
                    empleadoBase.StartDate = empleado.StartDate;
                    empleadoBase.Salary = empleado.Salary;
                    en.SaveChanges();
                }
                else
                {
                    PartTimeEmployee empleado = (PartTimeEmployee)emp;
                    Model.PartTimeEmployee empleadoBase = (Model.PartTimeEmployee)en.EmployeesTPH.Find(emp.Id);
                    empleadoBase.Name = empleado.Name;
                    empleadoBase.StartDate = empleado.StartDate;
                    empleadoBase.HourlyRate = empleado.HourlyRate;
                    en.SaveChanges();
                }
            }
        }

        public List<Employee> GetAllEmployees()
        {
            using (Model.PracticoObligatorioEntities en = new Model.PracticoObligatorioEntities())
            {
                List<Employee> listaEmpleados = new List<Employee>();
                en.EmployeesTPH.ToList().ForEach(x =>
                {
                    if(x.GetType().Name == "FullTimeEmployee")
                    {
                        Model.FullTimeEmployee emp = new Model.FullTimeEmployee();
                        emp = (Model.FullTimeEmployee)x;
                        FullTimeEmployee employee = new FullTimeEmployee()
                        {
                            Id = emp.EmployeeId,
                            Name = emp.Name,
                            StartDate = emp.StartDate,
                            Salary = emp.Salary
                        };
                        listaEmpleados.Add(employee);
                    }
                    else
                    {
                        Model.PartTimeEmployee emp = new Model.PartTimeEmployee();
                        emp = (Model.PartTimeEmployee)x;
                        PartTimeEmployee employee = new PartTimeEmployee()
                        {
                            Id = emp.EmployeeId,
                            Name = emp.Name,
                            StartDate = emp.StartDate,
                            HourlyRate = emp.HourlyRate
                        };
                        listaEmpleados.Add(employee);
                    }
                });
                return listaEmpleados;
            }
        }

        public Employee GetEmployee(int id)
        {
            using (Model.PracticoObligatorioEntities en = new Model.PracticoObligatorioEntities())
            {
                Model.Employee employee = en.EmployeesTPH.FirstOrDefault(x => x.EmployeeId == id);
                if(employee != null)
                {
                    if (en.EmployeesTPH.Find(id).GetType().Name == "FullTimeEmployee")
                    {
                        Model.FullTimeEmployee employeeBase = (Model.FullTimeEmployee)employee;
                        return new FullTimeEmployee()
                        {
                            Id = employeeBase.EmployeeId,
                            Name = employeeBase.Name,
                            StartDate = employeeBase.StartDate,
                            Salary = employeeBase.Salary
                        };
                    }
                    else
                    {
                        Model.PartTimeEmployee employeeBase = (Model.PartTimeEmployee)employee;
                        return new PartTimeEmployee()
                        {
                            Id = employeeBase.EmployeeId,
                            Name = employeeBase.Name,
                            StartDate = employeeBase.StartDate,
                            HourlyRate = employeeBase.HourlyRate
                        };
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
