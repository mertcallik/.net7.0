using AspnetCoreMert.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace AspnetCoreMert.TagHelpers
{
    [HtmlTargetElement("employee-m1")]
    public class EmployeeM1Class : TagHelper
    {
        private List<Employee> _employees;

        public EmployeeM1Class()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Mert", LastName = "Çalık", CityId = 1 },
                new Employee { Id = 2, FirstName = "Rabia", LastName = "Çalık", CityId = 1 },
                new Employee { Id = 3, FirstName = "Mini", LastName = "Çalık", CityId = 1 }
            };
        }

        private const string ListEmployeeAttribute = "count";

        [HtmlAttributeName(ListEmployeeAttribute)]
        public int ListCount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            var query = _employees.Take(ListCount);
            foreach (var employee in query)
            {
                stringBuilder.AppendFormat("<h2><a href='{0}'>{1}</a></h>", employee.Id, employee.FirstName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}