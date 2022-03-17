using FluentValidation;
using ManageGateway.Application.DTOs;

namespace ManageGateway.Application.Validators
{
    public class DeviceValidator : AbstractValidator<DeviceDTO>
    {
        public DeviceValidator()
        {
            RuleFor(x => x.Vendor)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.CreatedDate)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull();
                //.Must(ValidCreatedDate)
                //.WithMessage("Invalid format {PropertyName}");
            
            RuleFor(x => x.Status)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.GatewaySerialNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .NotNull();
        }

        //private bool ValidCreatedDate(DateTime date) 
        //    => DateTime.TryParse(date.ToString(), out _);
    }
}
