namespace RL.Areas.Accounting.Models {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BankCard {
        [Key]
        public int BankCardId { get; set; }
        [Required]
        public string BankCardName { get; set; }
        [Required]
        public string BankCardNumber { get; set; }

        [ForeignKey("BankAccountId")]
        public virtual BankAccount BankAccount { get; set; }
    }
}