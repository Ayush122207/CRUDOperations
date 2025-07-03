using System.ComponentModel.DataAnnotations;

namespace CRUDOperations.Models
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]
        public string? EmployeeFirstName { get; set; }
        [Required]
        public string? EmployeeLastName { get; set; }
        [Required]
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; }
    }
}
