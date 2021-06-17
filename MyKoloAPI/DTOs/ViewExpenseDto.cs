using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloAPI.DTOs
{
    public class ViewExpenseDto
    {
        public string ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
