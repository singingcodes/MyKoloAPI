using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyKoloAPI.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [MaxLength(11)]
        public string PhoneNumber { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public DateTime LastModifiedDate { get; set; }
        public virtual IEnumerable<Expense> Expenses { get; set; }
        public virtual IEnumerable<Savings> Savings { get; set; }

    }
}
