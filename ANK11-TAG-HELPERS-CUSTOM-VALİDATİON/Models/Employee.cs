using ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Custom_Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Models
{
    public class Employee
    {

        [Required]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Employee name is mandatory.")]
        [StringLength(50, ErrorMessage = "Employee Name should be less than or equal to fifty characters.")]
        public string Name { get; set; }
        public string LastName { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        
        [Required]
        public string Email { get; set; }
        [Required]
        [Range(20, 40, ErrorMessage = "Employee age should be in 20 to 40 range")]
        [AgeValidation]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Date Of Recruitment")]
        public DateTime DateOfRecruitment { get; set; }
        [DisplayName("Gender Type")]
        [EnumDataType(typeof(GenderType), ErrorMessage = "Gender type type is not valid.")]
        public GenderType GenderType { get; set; }
        [Display(Name = "Employee Salary")]
        [Required(ErrorMessage = "Salary Required!")]
        [SalaryValidation]
        public decimal Salary { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                    ErrorMessage = "Entered phone format is not valid.")]
        [PhoneValidation]
        public string PhoneNumber { get; set; }

        [EnumDataType(typeof(TitleType), ErrorMessage = "Title type is not valid.")]
        public TitleType TitleType { get; set; }
        
    }
    public enum GenderType
    {
        Bay = 0,
        Bayan,
        Diger
    }
    public enum TitleType
    {
        salesPerson = 0,
        manager,
        humanResources
    }

}
