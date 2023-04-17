using System.Text;
using AspnetCoreMert.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspnetCoreMert.TagHelpers
{
    [HtmlTargetElement("employe2-list2")]
    public class EmployeeTaghelper2:TagHelper
    {
        private List<Employee> _employees;
        public EmployeeTaghelper2()
        {
            _employees = new List<Employee>
            {
                new Employee { Id = 1,FirstName = "Merthan",LastName = "Çalık",CityId = 12}
            };
            
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder= new StringBuilder();

            var query = _employees;
            foreach (var employees in query)
            {
                stringBuilder.AppendFormat("<h2><a href='/Employee/Add/{0}'>{1}</a></h2>",employees.Id,employees.FirstName);
            }

            output.Content.SetHtmlContent(stringBuilder.ToString());

            base.Process(context, output);
        }
    }
    
}
