using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharp.Models
{
    public class Like
    {
    [Key]
    public int LikeId {get;set;}

 // ManyToMany relationship here //
    public int UserId  {get;set;}   
    public int IdeaId {get;set;}

    public User Liker {get;set;}
    public Idea Joker{ get;set; }

    public DateTime CreatedAt { get;set; } = DateTime.Now;
    public DateTime UpdatedAt { get;set; } = DateTime.Now;
    }   
}
