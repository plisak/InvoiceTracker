using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTracker.ViewModels
{
    public class InvoiceItemViewModel : INotifyPropertyChanged
    {
        private int _id;
        private int _orderNo;
        private string _itemName = null!;
        private decimal _quantity;
        private decimal _price;
        private decimal _vat;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public int OrderNo
        {
            get => _orderNo;
            set
            {
                _orderNo = value;
                OnPropertyChanged();
            }
        }

        public string ItemName
        {
            get => _itemName;
            set
            {
                _itemName = value;
                OnPropertyChanged();
            }
        }

        public decimal Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }

        public decimal VAT
        {
            get => _vat;
            set
            {
                _vat = value;
                OnPropertyChanged();
            }
        }

        public decimal NetSubtotal => Math.Round(Quantity * Price, 2);
        public decimal VatConversionFactor => (100 + VAT) / 100;
        public decimal GrossSubtotal => Math.Round(NetSubtotal * VatConversionFactor, 2);

        public event PropertyChangedEventHandler PropertyChanged = null!;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public InvoiceItemViewModel() { }

        public InvoiceItemViewModel(InvoiceItem invoiceItem)
        {
            Id = invoiceItem.Id;
            OrderNo = invoiceItem.OrderNo;
            ItemName = invoiceItem.ItemName;
            Quantity = invoiceItem.Quantity;
            Price = invoiceItem.Price;
            VAT = invoiceItem.Vat;
        }

        public InvoiceItem ToModel()
        {
            return new InvoiceItem(
                Id,
                OrderNo,
                ItemName,
                Quantity,
                Price,
                VAT
            );
        }

        public void UpdateValues(InvoiceItemViewModel item)
        {
            ItemName = item.ItemName;
            Quantity = item.Quantity;
            Price = item.Price;
            VAT = item.VAT;
        }
    }
}
