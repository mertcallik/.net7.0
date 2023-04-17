using AspnetCoreMert.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspnetCoreMert
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}