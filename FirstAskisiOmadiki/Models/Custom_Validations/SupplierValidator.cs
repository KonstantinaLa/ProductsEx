using FluentValidation;

namespace FirstAskisiOmadiki.Models.Custom_Validations
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("Name required")
                .Length(2, 20)
                .WithMessage("Length 2-20 characters")
                .Matches("^[a-zA-Z_ ]*$")
                .WithMessage("Only letters");
        }
    }
}