using Domain.Models;
using FluentValidation;

namespace Domain.Validators
{
    public class InvoiceItemValidator : AbstractValidator<InvoiceItem>
    {
        public InvoiceItemValidator()
        {
            RuleFor(item => item.ItemName).NotEmpty().WithMessage("Item Name must not be empty");
            RuleFor(item => item.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");
            RuleFor(item => item.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
            RuleFor(item => item.Vat).InclusiveBetween(0, 100).WithMessage("VAT must be between 0 and 100");
        }
    }
}
