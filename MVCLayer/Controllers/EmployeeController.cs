using MVCLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCLayer.Controllers
{
    public class EmployeeController : Controller
    {
        string apiRest = "http://localhost:58530/api/Employee/";

        [HttpGet]
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            List<EmployeeViewModel> EmpInfo = new List<EmployeeViewModel>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiRest);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result; 
                    EmpInfo = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(EmpResponse);

                }
                return View(EmpInfo);
            }
        }  
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<ActionResult> Create(FormCollection form)
        {
            MVCLayer.Models.EmployeeViewModel emp = new MVCLayer.Models.EmployeeViewModel()
            {
                Name = form["Name"],
                StartDate = form["StartDate"],
                TypeEmp = form["TypeEmp"],
                Salary = Int32.Parse(form["Salary"]),
                HourlyRate = Int32.Parse(form["HourlyRate"])
                //Name = "pep2e",
                //StartDate = "16/03/1995",
                //TypeEmp = "FullTIme",
                //Salary = 8978,
                //HourlyRate = 0,
                //Id = 2
                //Name = Name,
                //StartDate = StartDate.ToString(),
                //TypeEmp = TypeEmp,
                //Salary = Salary,
                //HourlyRate = HourlyRate,
                //Id = 2
            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiRest);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("", emp);
                if (Res.IsSuccessStatusCode)
                {
                    ViewBag.Resultado = "Empleado creado exitosamente";
                }
                else
                {
                    ViewBag.Resultado = "Hubo un error al intentar crear el usuario, por favor intentelo nuevamente";
                }
                return View();
            }

            //string myJson = "{'Name': '" + form["Name"] + "','StartDate': '" + form["StartDate"] + "','TypeEmp': '" + form["TypeEmp"] + "','Salary': '" + form["Salary"] + "','HourlyRate': '" + form["HourlyRate"] + "'}";
            //using (var client = new HttpClient())
            //{
            //    var response = await client.PostAsync(
            //        apiRest,
            //         new StringContent(myJson, Encoding.UTF8, "application/json"));
            //}
            //ViewBag.empleado = myJson;
            //return View();
        }
    }
}