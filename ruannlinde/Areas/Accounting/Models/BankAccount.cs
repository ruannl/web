namespace RL.Areas.Accounting.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BankAccount {
        [Required]
        public string AccountName { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [ForeignKey("BankId")]
        public virtual Bank Bank { get; set; }

        [Key]
        public int BankAccountId { get; set; }

        [ForeignKey("BankCardId")]
        public virtual IList<BankCard> BankCards { get; set; }
    }
}