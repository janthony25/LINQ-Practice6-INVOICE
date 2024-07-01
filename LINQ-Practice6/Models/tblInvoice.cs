using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice6.Models
{
    public class tblInvoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateTime DateAdded { get; set; }
        public string? PaymentTerm { get; set; }
        public string? Notes { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Discount { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? TotalAmount { get; set; }

        // Foreign key to tblCustomer
        public string CarRego { get; set; }
        public tblCustomer? tblCustomer { get; set; }

        // has many InvoiceItem
        public ICollection<tblInvoiceItem>? tblInvoiceItem { get; set; }
    }
}
