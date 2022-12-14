using Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class CarValidator : FluentValidation.AbstractValidator<CarDTO>
    {
        public CarValidator()
        {
            RuleFor(x => x.Model)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.ImagePath)
                .NotNull()
                .NotEmpty()
                .Must(IsUrl).WithMessage("The property {PropertyName} must be a valid URL address.");
            RuleFor(x => x.Description)
                .MaximumLength(1000);
            RuleFor(x => x.StoKMh)
                .GreaterThanOrEqualTo(0);
        }

        private static bool IsUrl(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
