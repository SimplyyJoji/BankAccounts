using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transactions
    {
        [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
        public int TransactionId { get; set; }
 
        [Required(ErrorMessage = "is required")]
        [Display(Name = "Amount")]
        public int Amount { get; set; }
        public int UserId {get;set;}
        // Navigation property for related User object
        public User Creator {get;set;} 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
    }