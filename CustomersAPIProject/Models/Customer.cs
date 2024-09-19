using System.ComponentModel.DataAnnotations;

namespace CustomersAPIProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
