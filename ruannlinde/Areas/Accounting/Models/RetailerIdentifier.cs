namespace RL.Areas.Accounting.Models {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RetailerIdentifier {
        [Required]
        public string Identity { get; set; }

        [ForeignKey("RetailerId")]
        public virtual Retailer Retailer { get; set; }

        [Key]
        public int RetailerIdentifierId { get; set; }
    }
}