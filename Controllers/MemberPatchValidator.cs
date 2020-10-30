using System.ComponentModel.DataAnnotations;
using FluentValidation;
using PhoneNumbers;

namespace HealthEquityMembers.Controllers
{
    public class MemberPatchValidator : AbstractValidator<MemberPatch>
    {
        public MemberPatchValidator()
        {
            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            RuleFor(r => r.Email)
                .Transform(d => d?.Trim())
                .Custom((d, context) =>
                {
                    if (!new EmailAddressAttribute().IsValid(d))
                    {
                        context.AddFailure("Please provide a valid email address");
                    }
                });
            RuleFor(r => r.FirstName).Transform(d => d?.Trim());
            RuleFor(r => r.LastName).Transform(d => d?.Trim());
            RuleFor(r => r.PhoneNumber).Transform(d => d?.Trim())
                .Custom((d, context) =>
                {
                    var isInvalid = false;
                    try
                    {
                        var phoneNumber = phoneNumberUtil.Parse(d, null);
                        isInvalid = phoneNumberUtil.IsValidNumber(phoneNumber);
                    }
                    catch (NumberParseException)
                    {
                        isInvalid = true;
                    }

                    if (isInvalid)
                    {
                        context.AddFailure("Please enter a valid phone number");
                    }
                });
        }
    }
}