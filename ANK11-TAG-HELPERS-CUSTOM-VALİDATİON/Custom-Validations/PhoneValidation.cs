using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class PhoneValidation: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string _phoneNumber = value.ToString();

            if (_phoneNumber.Length == 12)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Phone number is not valid.");
            }
        }
    }
}
