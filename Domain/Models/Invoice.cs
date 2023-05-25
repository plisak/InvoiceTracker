using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Currency { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateDelivered { get; set; }
        public Company Customer { get; set; }
        public Company Vendor { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        // Other invoice related properties
    }
}
