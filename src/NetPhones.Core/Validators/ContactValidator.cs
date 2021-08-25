using FluentValidation;
using NetPhones.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPhones.Core.Validators
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .WithMessage("First name is a required field");

            RuleFor(c => c.FirstName)
                .MaximumLength(30)
                .WithMessage("First name must have at most {MaxLength} characters");

            RuleFor(c => c.LastName)
                .MaximumLength(50)
                .WithMessage("Last name must have at most {MaxLength} characters");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty()
                .WithMessage("Phone number is a required field");

            RuleFor(c => c.PhoneNumber)
                .MaximumLength(14)
                .WithMessage("Phone number must have at most {MaxLength} characters");
        }
    }
}
