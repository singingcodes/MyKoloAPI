using Microsoft.AspNetCore.Mvc;
using MyKoloAPI.Data;
using MyKoloAPI.DTOs;
using MyKoloAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyKoloAPI.Controllers
{
    [ApiController]
    [Route("Expenses")]

    public class ExpensesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ExpensesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult AddExpense(AddExpenseDto requestBody)
        {
            Expense expense = new Expense()
            {
                Id = Guid.NewGuid().ToString(),
                UserId = requestBody.UserId,
                Amount = requestBody.Amount,
                Description = requestBody.Description

            };
            _context.Set<Expense>().Add(expense);
            _context.SaveChanges();
            return Ok(expense.Id);
        }
        [HttpGet]
        public IActionResult GetAllUserExpenses()
        {
            List<Expense> ExpensesData = _context.Expenses.ToList();
            List<ViewExpenseDto> Expenses = new List<ViewExpenseDto>();
            
            if (ExpensesData.Count == 0)
            {
                return NotFound();
            }
            else
            {
                foreach (var expense in ExpensesData)
                {
                    Expenses.Add(new ViewExpenseDto()
                    {
                        ExpenseId=expense.Id,
                        Amount = expense.Amount,
                        Description = expense.Description
                    });
                }
            }
            return Ok(Expenses);
        }
        [HttpGet("{userId}")]
        public IActionResult GetExpensesById(string userId)
        {
            List<Expense> expenses = _context.Expenses.Where(expense => expense.UserId == userId).ToList();
            List<ViewExpenseDto> foundExpenses = new List<ViewExpenseDto>();
            if (expenses.Count == 0)
            {
                return NotFound();
            }
            else
            {

                foreach (var foundExpense in expenses)
                {
                    foundExpenses.Add(new ViewExpenseDto()
                    {
                        ExpenseId =foundExpense.Id,
                        Amount = foundExpense.Amount,
                        Description = foundExpense.Description
                    });
                }
            }
            return Ok(foundExpenses);
        }

        [HttpPut]
        public IActionResult UpdateExpense([FromQuery]string UserId, [FromBody] UpdateExpenseDto expenseToUpdate)
        {
            return Ok();
        }
    }
}
 