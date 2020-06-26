using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharp.Models
{
    public class User
    {
        [Key]
        public int UserId { get;set; }

        //black belt request for uniqueness of firstname happens in the home controller // 
        [Required(ErrorMessage="A unique first name is neccessary. Here are a few possibilities: Janet, Henry, Lawrence, Madeline")]
        [RegularExpression("^[a-zA-Z][a-zA-Z\\s]+$", ErrorMessage="Only letters and spaces are allowed. No Symbols please.")]
        [Display(Name = "Name: ")]
        public string Name { get;set; }


        [Required(ErrorMessage="A last name is neccessary. Here are a few possibilities: Brown, Smith, Washington, Childs")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage="We'll need an alias with only letters and numbers. No spaces and no symbols please.")]
        [Display(Name = "Alias: ")]
        public string Alias { get;set; }


        [Required(ErrorMessage="We'll need an email to contact you.")]
        [EmailAddress(ErrorMessage="Whoops. Something is missing? Is that a valid email address?")]
        [Display(Name = "Email: ")]
        public string Email {get;set;}


        [DataType(DataType.Password)]
        [Required(ErrorMessage="A password of 8 characters is required.")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$", ErrorMessage="Password must contain at least 1 letter and 1 number")]
        [MinLength(8, ErrorMessage="Your password must be 8 characters in length.")]
        [Display(Name = "Password: ")]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        public string Confirm {get;set;}   
        
        // Navigation properties/foreign keys //
        public List<Idea> CreatedByUser { get;set; }

         // Added a validation to ensure that this is a unique property (each hobby) in HomeController
        public List<Like> LikedByUser { get;set; }
    
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        
    }
}