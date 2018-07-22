namespace RL.Areas.Accounting.Models {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BudgetItem {

        [Key]
        public int BudgetItemId { get; set; }
        [Required]
        public string BudgetDescription { get; set; }
        [Required]
        public double BudgetItemAmount { get; set; }

        [ForeignKey("BudgetItemCategoryId")]
        public virtual BudgetItemCategory BudgetItemCategory { get; set; }
    }
}