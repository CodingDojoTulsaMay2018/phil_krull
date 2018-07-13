using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationshipDemo.Models
{
    public class Dojo
    {
        [Key]
        public long Id {get;set;}
        public string Name {get;set;}

        [Column("Dojo_id")]
        public List<Ninja> Ninjas {get; set;}
        public DateTime Created_at {get;set;}
        public DateTime Updated_at {get;set;}

        public Dojo()
        {
            Ninjas = new List<Ninja>();
            Created_at = DateTime.Now;
        }
    }
}