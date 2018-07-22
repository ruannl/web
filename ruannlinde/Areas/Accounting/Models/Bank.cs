namespace RL.Areas.Accounting.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Bank {
        [Key]
        public int BankId { get; set; }
        public string ImageSource { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("StatementId")]
        public virtual List<Statement> Statements { get; set; }

        [ForeignKey("BankCardId")]
        public virtual List<BankCard> BankCards { get; set; }
    }
}