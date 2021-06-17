﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloAPI.Models
{
    public class Savings
    {
        [Key]
        public string Id { get; set; }
        public virtual User User { get; set; }
        public string UserId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [MaxLength(256)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; }

    }
}
