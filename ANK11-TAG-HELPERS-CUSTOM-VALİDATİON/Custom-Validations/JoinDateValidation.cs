using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class JoinDateValidation:ValidationAttribute
    {

        //bunu siz dolduracaksınız

        //istenilenler => join date bugünden büyük olamaz. 10 yıllık bir şirket olduğunu varsayalım. 11 yıllık çalışan olamaz.

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime _joinDate = Convert.ToDateTime(value);

            if (_joinDate < DateTime.Now && ((DateTime.Now.Year)- (_joinDate.Year)) < 10)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Join Date is not valid.");
            }
        }
      
    }
}
