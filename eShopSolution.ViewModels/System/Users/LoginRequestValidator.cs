using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username is require");
            RuleFor(x => x.Password).NotEmpty().WithMessage("password is require")
                .MinimumLength(6).WithMessage("Password is at least 6 characters");
        }
    }
}
