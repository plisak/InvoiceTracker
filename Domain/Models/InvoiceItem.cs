namespace Domain.Models
{
    public class InvoiceItem
    {
        public InvoiceItem(int id, int orderNo, string itemName, decimal quantity, decimal price, decimal vat)
        {
            Id = id;
            OrderNo = orderNo;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
            Vat = vat;
        }
        public int Id { get; }
        public int OrderNo { get; }
        public string ItemName { get; }
        public decimal Quantity { get; }
        public decimal Price { get; }
        public decimal Vat { get; }
        public decimal NetSubtotal => Quantity * Price;
        public decimal VatConversionFactor => (100 + Vat) / 100;
        public decimal GrossSubtotal => NetSubtotal * VatConversionFactor;
        public decimal VatAmount => GrossSubtotal - NetSubtotal;
    }
}