using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIRestLayer.Controllers
{
    [EnableCors(origins: "http://localhost:60250", headers: "*", methods: "*")]
    public class EmployeeController : ApiController
    {
        BusinessLogicLayer.BLEmployees blHandler = new BusinessLogicLayer.BLEmployees(new DataAccessLayer.DALEmployeesEF());

        public HttpResponseMessage Get()
        {
            try
            {
                List<Shared.Entities.Employee> empployees = blHandler.GetAllEmployees();
                return Request.CreateResponse(HttpStatusCode.OK, empployees);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        public HttpResponseMessage Get(int id)
        {
            try
            {
                Shared.Entities.Employee emp = blHandler.GetEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, emp);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }
        
        public HttpResponseMessage Post(Shared.Entities.EmployeeAPIRest emp)
        {
            try
            {
                if(emp.TypeEmp == "FullTime")
                {
                    Shared.Entities.FullTimeEmployee empleado = new Shared.Entities.FullTimeEmployee()
                    {
                        Name = emp.Name,
                        StartDate = Convert.ToDateTime(emp.StartDate),
                        Salary = emp.Salary
                    };
                    blHandler.AddEmployee(empleado);
                }
                else if (emp.TypeEmp == "PartTime")
                {
                    Shared.Entities.PartTimeEmployee empleado = new Shared.Entities.PartTimeEmployee()
                    {
                        Name = emp.Name,
                        StartDate = Convert.ToDateTime(emp.StartDate),
                        HourlyRate = emp.HourlyRate
                    };
                    blHandler.AddEmployee(empleado);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Tipo de usuario incorrecto");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Usuario creado correctamente");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                blHandler.DeleteEmployee(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Usuario eliminado correctamente");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        public HttpResponseMessage Put(Shared.Entities.EmployeeAPIRest emp)
        {
            try
            {
                if (emp.TypeEmp == "FullTime")
                {
                    Shared.Entities.FullTimeEmployee empleado = new Shared.Entities.FullTimeEmployee()
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        StartDate = Convert.ToDateTime(emp.StartDate),
                        Salary = emp.Salary
                    };
                    blHandler.UpdateEmployee(empleado);
                }
                else if (emp.TypeEmp == "PartTime")
                {
                    Shared.Entities.PartTimeEmployee empleado = new Shared.Entities.PartTimeEmployee()
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        StartDate = Convert.ToDateTime(emp.StartDate),
                        HourlyRate = emp.HourlyRate
                    };
                    blHandler.UpdateEmployee(empleado);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Tipo de usuario incorrecto");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Usuario actualizado correctamente");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        public HttpResponseMessage GetCalcPartTimeEmployeeSalary(int id, int hours)
        {
            try
            {
                double res = blHandler.CalcPartTimeEmployeeSalary(id, hours);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e);
            }
        }
    }
}
