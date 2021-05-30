using FluentValidation;

namespace FirstAskisiOmadiki.Models.Custom_Validations
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Title)
                //.NotEmpty()
                //.WithMessage("Title required")
                .Length(2, 20)
                .WithMessage("Length 2-20 characters")
                .Matches("^[a-zA-Z_ ]*$")
                .WithMessage("Only letters");

            RuleFor(p => p.IsExpired)
                .NotEmpty()
                .WithMessage("Date required");

            RuleFor(p => p.Price)
                .NotEmpty()
                .WithMessage("Required");


        }
    }
}