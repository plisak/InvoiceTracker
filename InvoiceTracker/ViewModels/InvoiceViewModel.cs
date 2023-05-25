using Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTracker.ViewModels
{
    public class InvoiceViewModel : INotifyPropertyChanged
    {
        private string number;
        private string currency;
        private DateTime dateOfIssue;
        private DateTime dateDelivered;
        //private CustomerViewModel customer;
        //private VendorViewModel vendor;
        private BindingList<InvoiceItemViewModel> invoiceItems;

        public string Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged();
            }
        }

        public string Currency
        {
            get => currency;
            set
            {
                currency = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfIssue
        {
            get => dateOfIssue;
            set
            {
                dateOfIssue = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateDelivered
        {
            get => dateDelivered;
            set
            {
                dateDelivered = value;
                OnPropertyChanged();
            }
        }

        //public CustomerViewModel Customer
        //{
        //    get => customer;
        //    set
        //    {
        //        customer = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public VendorViewModel Vendor
        //{
        //    get => vendor;
        //    set
        //    {
        //        vendor = value;
        //        OnPropertyChanged();
        //    }
        //}

        public BindingList<InvoiceItemViewModel> InvoiceItems
        {
            get => invoiceItems;
            set
            {
                invoiceItems = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public InvoiceViewModel()
        {
            InvoiceItems = new BindingList<InvoiceItemViewModel>();
        }

        //public InvoiceViewModel(Invoice invoice)
        //{
        //    Number = invoice.Number;
        //    Currency = invoice.Currency;
        //    DateOfIssue = invoice.DateOfIssue;
        //    DateDelivered = invoice.DateDelivered;
        //    //Customer = new CustomerViewModel(invoice.Customer);
        //    //Vendor = new VendorViewModel(invoice.Vendor);
        //    InvoiceItems = new BindingList<InvoiceItemViewModel>(invoice.InvoiceItems.Select(item => new InvoiceItemViewModel(item)));
        //}

        public Invoice ToModel()
        {
            return new Invoice
            {
                Number = Number,
                Currency = Currency,
                DateOfIssue = DateOfIssue,
                DateDelivered = DateDelivered,
                //Customer = Customer.ToModel(),
                //Vendor = Vendor.ToModel(),
                InvoiceItems = InvoiceItems.Select(item => item.ToModel()).ToList()
            };
        }
    }
}
