using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pension_Management_Portal.Models
{
    public class Register
    {
        [Key]
        [DisplayName("Pensioner Id")]
        public int PensionerId { get; set; }
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public DateTime Dateofbirth { get; set; }
        [Required]
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Only Numbers and Alphabets acceptable")]
        public string PAN { get; set; }
        public int SalaryEarned { get; set; }
        public int Allowances { get; set; }
        [Required]
        [RegularExpression("^[0-9]{12}$", ErrorMessage = "Should be combination of 12-digits ONLY")]
        public string AadharNumber { get; set; }
        public PensionTypeValue PensionType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public BankType BankType { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [MaxLength(30, ErrorMessage = "Password must have minimum 8 Characters"), MinLength(8)]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase      Alphabet, 1 Number and 1 Special Character")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please enter confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match, Try again !")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}