using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    //[Route("[controller]")]
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[Route("[action]")]
        //[Route("")]
        public string List()
        {
            return "List() of DepartmentsController";
        }
        //[Route("[action]")]
        public string Details()
        {
            return "Details() of DepartmentsController";
        }
    }
}