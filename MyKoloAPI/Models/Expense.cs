using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyKoloAPI.Models
{
    public class Expense
    {
        [Key]
        public string Id { get; set; }
        [Required]
        
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
