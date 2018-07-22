namespace RL.Areas.Accounting.Models {
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionEntry {
        [ForeignKey("BankCardId")]
        public virtual BankCard BankCard { get; set; }

        [ForeignKey("BudgetItemId")]
        public virtual BudgetItem BudgetItem { get; set; }

        [ForeignKey("RetailerId")]
        public virtual Retailer Retailer { get; set; }

        [ForeignKey("StatementId")]
        public virtual Statement Statement { get; set; }

        [Required]
        public double TransactionAmount { get; set; }

        [Required]
        public double TransactionBalance { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public string TransactionDescription { get; set; }

        [Key]
        public int TransactionId { get; set; }

        [ForeignKey("TransactionTypeId")]
        public virtual TransactionType TransactionType { get; set; }
    }
}