using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CSharp.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId { get; set; }

        [Required]
        [MinLength(5, ErrorMessage="Your idea or joke must be at least 5 characters in length.")]
        public string Content { get; set; }
        public bool IsIdea { get; set; } = false;

        // Foreign Key and ManyToMany Nav property //
        public int UserId { get;set; }
        public User Creator { get;set; }
        public List<Like> UsersWhoLikeThisIdea { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

