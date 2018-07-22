namespace RL.Areas.Accounting.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TransactionType {
        [Key]
        public int TransactionTypeId { get; set; }

        [ForeignKey("TransactionTypeIdentifierId")]
        public virtual List<TransactionTypeIdentifier> TransactionTypeIdentifiers { get; set; }

        [Required]
        public string TransactionTypeName { get; set; }
    }
}