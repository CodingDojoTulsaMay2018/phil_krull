using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationshipDemo.Models
{
    public class Ninja
    {
        [Key]
        public long Id {get;set;}
        [Column("Dojo_name")]
        public string Name {get;set;}

        [Column("Dojo_id")]
        public Dojo Dojo {get; set;}
        public DateTime Created_at {get;set;}
        public DateTime Updated_at {get;set;}

        public Ninja()
        {
            Created_at = DateTime.Now;
        }
    }
}