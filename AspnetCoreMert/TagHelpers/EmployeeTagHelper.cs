using AspnetCoreMert.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace AspnetCoreMert.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeTagHelper : TagHelper
    {
        private List<Employee> _employees;

        public EmployeeTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee{Id = 1,FirstName = "Mert",LastName = "Çalık",CityId = 1},
                new Employee{Id = 2,FirstName = "Rabia",LastName = "Çalık",CityId = 1},
                new Employee{Id = 3,FirstName = "Mini",LastName = "Çalık",CityId = 1}
            };
        }

        private const string ListCountAttributename = "count";

        [HtmlAttributeName(ListCountAttributename)]
        public int ListCount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees.Take(ListCount);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var data in query)
            {
                stringBuilder.AppendFormat("<h2><a href='Employee/Details/{0}'>{1}</a></h2>", data.Id, data.FirstName);
            }

            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }
    }
}