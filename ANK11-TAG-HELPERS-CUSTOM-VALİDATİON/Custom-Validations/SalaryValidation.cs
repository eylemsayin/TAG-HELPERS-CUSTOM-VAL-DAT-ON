using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations
{
    public class SalaryValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            decimal _salary = Convert.ToInt32(value);
            decimal minimumWage = 850680;

            if (_salary < minimumWage )
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Salary is not valid.");
            }
        }
    }
}
