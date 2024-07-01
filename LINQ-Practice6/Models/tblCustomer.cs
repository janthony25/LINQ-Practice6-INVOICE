using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice6.Models
{
    public class tblCustomer
    {
        [Key]
        public string CarRego { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string PaymentStatus { get; set; }

        public ICollection<tblInvoice> tblInvoice { get; set; }
    }
}
