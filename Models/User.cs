using System;
using System.ComponentModel.DataAnnotations;

namespace cd_c_valFormSub.Models
{
    public class User
    {
        [Required(ErrorMessage = "You must enter a first name.")]
        [MinLength(4, ErrorMessage = "Last name must be at least 4 characters long.")]
        [Display(Name = "First Name:")]
        public string firstname {get;set;}

        [Required(ErrorMessage = "You must enter a last name.")]
        [MinLength(4, ErrorMessage = "Last name must be at least 4 characters long.")]
        [Display(Name = "Last Name:")]
        public string lastname {get;set;}

        [Required(ErrorMessage = "You must enter an age.")]
        [Range(0, 999, ErrorMessage = "Age can not be less than 1 or more than 999")]
        [Display(Name = "Age:")]
        public int age {get;set;}

        [Required(ErrorMessage = "You must enter an email address.")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        [Display(Name = "Email Address:")]
        public string email {get;set;}

        [Required(ErrorMessage = "You must enter a password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string password {get;set;}
    }
}