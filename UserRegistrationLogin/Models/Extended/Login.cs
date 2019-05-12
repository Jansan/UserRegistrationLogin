using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserRegistrationLogin.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class Login
    {
        public string ConfirmPassword { get; set; }

    }
    public class UserMetadata
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First name is required",AllowEmptyStrings =false)]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Last name is required")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Email ID required")]
        [Display(Name ="Email Id")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name ="Date of birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:MM-dd-yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required(AllowEmptyStrings =false,ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimun 6 characters required")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }

        
    }
}