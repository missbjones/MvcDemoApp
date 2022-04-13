using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000,999999, ErrorMessage = "You must enter a valid employee ID")]
        public int EmployeeId { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must provide your first name.")]
        public string FirstName { get; set; }



        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must provide your last name.")]
        public string LastName { get; set; }



        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must provide your email address.")]
        public string EmailAddress { get; set; }



        [Display(Name = "Confirm Email Address")]
        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress", ErrorMessage = "Email does not match")]
        public string ConfirmEmail { get; set; }



        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must provide a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage ="Make sure your password is at least 6 characters long")]
        public string Password { get; set; }



        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}