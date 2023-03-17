﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string? ProfilePicturURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
