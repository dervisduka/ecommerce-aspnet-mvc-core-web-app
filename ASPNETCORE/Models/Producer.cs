﻿using System.ComponentModel.DataAnnotations;

namespace ASPNETCORE.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]

        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]

        public string FullName { get; set; }

        [Display(Name = "Biograhpy")]

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
