using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class CustomerProcess
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
