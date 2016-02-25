﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [ClassicMovie(1960)]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]        
        [Required(AllowEmptyStrings =true)]
        [Range(0, 999.99)]        
        public float Price { get; set; }
        
        [Required]
        public Genre Genre { get; set; }

        [Required]
        [FamilyMovie]
        public string Audience { get; set; }

        public List<Review> Reviews { get; set; }
    }
}
