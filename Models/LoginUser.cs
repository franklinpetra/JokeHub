using System;
using System.Linq;
using CSharp.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharp.Models 
{   
    public class LoginUser
    {

        [Required(ErrorMessage="An email is required for login.")]
        [EmailAddress(ErrorMessage="Whoops. Something is missing? Is that a valid email address? Typo perhaps?")]
        [Display(Name = "Email: ")]
        public string Email {get;set;}

        [Required(ErrorMessage="Your password is required.")]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        
    }
}