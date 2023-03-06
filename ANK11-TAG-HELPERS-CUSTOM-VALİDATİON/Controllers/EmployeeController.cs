using ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult EmployeeDetails()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult EmployeeDetails(Employee employee)
        {
            return View(employee);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
