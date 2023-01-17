﻿using System.ComponentModel.DataAnnotations;

namespace E_comerce.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


        public List<Movie> Movies { get; set; }
        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
