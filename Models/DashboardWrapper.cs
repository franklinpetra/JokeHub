using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharp.Models
{
    public class DashboardWrapper
    {
        public User LoggedUser { get; set; }
        public List<User> AllUsers { get; set; }
        public List<Idea> AllIdeas { get; set; }
        public Like LikeForm { get; set; } 
        public Idea IdeaForm { get;set; }
        
    }
}