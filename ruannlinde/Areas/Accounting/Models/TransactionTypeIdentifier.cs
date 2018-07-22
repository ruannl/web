namespace RL.Areas.Accounting.Models {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionTypeIdentifier {

        [ForeignKey("TransactionTypeId")]
        public virtual TransactionType TransactionType { get; set; }

        [Key]
        public int TransactionTypeIdentifierId { get; set; }

        [Required]
        public string TransactionTypeIdentifierPrimary { get; set; }

        public string TransactionTypeIdentifierSecondary { get; set; }
    }
}