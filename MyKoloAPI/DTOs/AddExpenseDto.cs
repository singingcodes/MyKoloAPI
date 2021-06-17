namespace MyKoloAPI.DTOs

{
    public class AddExpenseDto
    {
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}