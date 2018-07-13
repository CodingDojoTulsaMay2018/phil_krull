using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TheWall.Models{
    public class Message
    {
        [Key]
        public int Id {get;set;}

        public string Content {get;set;}

        [Column("Creator_id")]
        // ^^ trying to change the default to ^^
        public User Creator {get; set;}
        // ^^ defaults to CreaterId for a MySQL column name

        public List<Post> Posts {get; set;}
        public DateTime Created_At {get; set;}

        public Message()
        {
            List<Post> Posts = new List<Post>();
            Created_At = DateTime.Now;
        }
    }
}