using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheWall.Models{
    public class Post
    {
        [Key]
        public int Id {get;set;}

        public string Content {get;set;}

        public User Creator {get; set;}

        public Message BelongsTo {get; set;}
        public DateTime Created_At {get; set;}

        public Post()
        {
            Created_At = DateTime.Now;
        }
    }
}