namespace RL.Areas.Accounting.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Retailer {
        [Key]
        public int RetailerId { get; set; }

        [ForeignKey("RetailerIdentifierId")]
        public virtual List<RetailerIdentifier> RetailerIdentifiers { get; set; }

        [Required]
        public string RetailerName { get; set; }

        [ForeignKey("TransactionEntryId")]
        public virtual List<TransactionEntry> TransactionEntries { get; set; }
    }
}