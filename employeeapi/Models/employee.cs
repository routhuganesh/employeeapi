using System.ComponentModel.DataAnnotations;
namespace employeeapi.Models
{
    public class employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
