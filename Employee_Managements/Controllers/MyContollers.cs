using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Employee_Managements.Models;

namespace Employee_Managements.Controllers
{
    public class MyController : Controller
    {
        public List<EmployeeModel> Employees; 

        public MyController()
        {
            Employees = new List<EmployeeModel>(); 
            Employees.Add(new EmployeeModel(){ Id = "1", Name = "ram", sal = "1231" }); 
            Employees.Add(new EmployeeModel(){ Id = "2", Name = "sita", sal = "100231" }); 
        } 

        public IActionResult GetEmployee(int id) 
        {
            var emp = Employees.Find(x => x.Id == id.ToString()); 
            return View(emp); 
        }

        public IActionResult Index(){
            var empstd = Employees;
            return View(Employees);
        }
    }
}