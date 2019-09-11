using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer.DALEmployeesEF en = new DataAccessLayer.DALEmployeesEF();

            //Shared.Entities.Employee prueba = en.GetEmployee(1);
            //if(prueba != null)
            //{
            //    if (prueba.GetType().Name == "FullTimeEmployee")
            //    {
            //        Shared.Entities.FullTimeEmployee prueba1 = (Shared.Entities.FullTimeEmployee)prueba;
            //        Console.WriteLine(prueba1.Name + " " + prueba1.StartDate + " " + prueba1.Salary);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("null");
            //}

            //Shared.Entities.PartTimeEmployee pruebaAdd = new Shared.Entities.PartTimeEmployee()
            //{
            //    Name = "Putin",
            //    StartDate = Convert.ToDateTime("13/03/1996"),
            //    HourlyRate = 65

            //};
            //en.AddEmployee(pruebaAdd);


            //en.DeleteEmployee(11);

            //en.AddEmployee(emplo);
            //foreach(var emp in en.EmployeesTPH)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            //List<Shared.Entities.Employee> listaEmpleados = en.GetAllEmployees();
            //listaEmpleados.ForEach(x =>
            //{
            //    if (x.GetType().Name == "FullTimeEmployee")
            //    {
            //        Shared.Entities.FullTimeEmployee empleado = (Shared.Entities.FullTimeEmployee)x;
            //        Console.WriteLine("Nombre: " + empleado.Name + " Salario " + empleado.Salary);
            //    }
            //    else
            //    {
            //        Shared.Entities.PartTimeEmployee empleado = (Shared.Entities.PartTimeEmployee)x;
            //        Console.WriteLine("Nombre: " + empleado.Name + " Ratio " + empleado.HourlyRate);
            //    }
            //});

            //Shared.Entities.FullTimeEmployee pruebaUpdate = new Shared.Entities.FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Lucas",
            //    StartDate = Convert.ToDateTime("13/03/1996"),
            //    Salary = 6000
            //};
            //en.UpdateEmployee(pruebaUpdate);

            //BusinessLogicLayer.BLEmployees horasPartTime = new BusinessLogicLayer.BLEmployees(en);
            //try
            //{
            //    Console.WriteLine(horasPartTime.CalcPartTimeEmployeeSalary(1323, 2));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
