using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class AgeValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int _age = Convert.ToInt32(value);

            if (_age < 41 && _age > 19)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Age is not valid.");
            }
        }
        public override bool IsValid(object? value) //iki farklı kullanımı mevcut. Aradaki farkları araştırın.
        {
            return base.IsValid(value);
        }
    }
}
