using System.ComponentModel;

namespace AspnetCoreMert.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("*First Name*")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CityId { get; set; }
    }
}
