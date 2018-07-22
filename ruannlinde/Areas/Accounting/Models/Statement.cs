namespace RL.Areas.Accounting.Models {
    using System.ComponentModel.DataAnnotations;

    public class Statement {
        [Key]
        public int StatementId { get; set; }
        public double AccountBalance { get; set; }
        public double AvailableBalance { get; set; }
        
        public virtual BankAccount BankAccount { get; set; }
    }
}