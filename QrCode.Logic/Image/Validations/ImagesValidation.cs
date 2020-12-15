using FluentValidation;
using QrCode.Data;

namespace QrCode.Logic.Image.Validations
{
    public class ImagesValidation : AbstractValidator<UserImage>
    {
        public ImagesValidation()
        {
            RuleFor(x => x.Code)
                .NotNull().WithMessage("کد عکس نمی‌تواند خالی باشد");
            
            RuleFor(x => x.Size)
                .NotNull().WithMessage("سایز عکس وارد نشده است");
        }
    }
}
