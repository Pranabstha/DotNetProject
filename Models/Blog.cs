﻿using BislariumCW.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BislariumCW.Models
{
    public class Blog
    {

        [Key]
        public int BlogID { get; set; }
        [Required]
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }

        public string BlogImageUrl { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        public string UserId { get; set; }
        
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
