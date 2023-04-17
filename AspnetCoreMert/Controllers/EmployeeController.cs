using AspnetCoreMert.Entities;
using AspnetCoreMert.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspnetCoreMert.Controllers
{
    public class EmployeeController : Controller
    {
        private ICalculator _calculator;

        public EmployeeController(ICalculator calculator)
        {
            _calculator= calculator;
        }
        public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ankara", Value = "06" },
                    new SelectListItem { Text = "İstanbul", Value = "34" }
                }
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public JsonResult Add(Employee employee)
        {
            return Json(employee);
        }

        public string Calculate()
        {
            return _calculator.Calculate(100).ToString();
        }
    }
}