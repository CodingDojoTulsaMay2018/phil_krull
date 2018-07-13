using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TheWall.Models{
    public class User
    {
        [Key]
        public int Id {get;set;}

        public string First_name {get;set;}

        public DateTime Created_At {get; set;}

        public List<Message> Messages {get; set;}

        public User()
        {
            Created_At = DateTime.Now;
            Messages = new List<Message>();
        }
    }
}