using System.ComponentModel.DataAnnotations;

namespace SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required]//not optional
        public string? Description {  get; set; }
                                             
    }
}
