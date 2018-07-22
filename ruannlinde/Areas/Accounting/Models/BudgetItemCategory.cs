namespace RL.Areas.Accounting.Models {
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class BudgetItemCategory {
        [Key]
        public int BudgetItemCategoryId { get; set; }

        [Required]
        public string BudgetItemCategoryName { get; set; }

        [ForeignKey("BudgetItemId")]
        public virtual List<BudgetItem> BudgetItems { get; set; }
    }
}