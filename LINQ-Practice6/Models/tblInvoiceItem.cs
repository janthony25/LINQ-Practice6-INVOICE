using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice6.Models
{
    public class tblInvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal LaborPrice { get; set; }

        // FOREIGN KEY to tblInvoice
        public int InvoiceId { get; set; }
        public tblInvoice tblInvoice { get; set; }
    }
}
