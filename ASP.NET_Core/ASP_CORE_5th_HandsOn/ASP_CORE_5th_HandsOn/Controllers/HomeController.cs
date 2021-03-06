using ASP_CORE_5th_HandsOn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_CORE_5th_HandsOn.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> eList;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            eList = new List<Employee>();
            eList.Add(new Employee()
            {
                Id = 1,
                Name = "John",
                Salary = 10000,
                IsPermanent = true
            });
            eList.Add(new Employee()
            {
                Id = 2,
                Name = "Smith",
                Salary = 5000,
                IsPermanent = false
            });
            eList.Add(new Employee()
            {
                Id = 3,
                Name = "Mark",
                Salary = 5000,
                IsPermanent = false
            });
            eList.Add(new Employee()
            {
                Id = 4,
                Name = "Mary",
                Salary = 5000,
                IsPermanent = false
            });
        }

        public IActionResult Index()
        {
            return View(eList);
        }

        public IActionResult GetEmployeeList()
        {
            
            return View(eList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
