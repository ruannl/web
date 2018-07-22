namespace RL.Areas.Accounting.Providers {
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    using RL.Areas.Accounting.Models;

    public class AccountingRepository : IDisposable {

        private readonly AccountingContext dbContext;
        private readonly IDisposable disposableImplementation;

        public AccountingRepository(AccountingContext context, IDisposable disposableImplementation) {
            dbContext = context;
            this.disposableImplementation = disposableImplementation;
        }

        public IList<Bank> ReturnBanks() {
            return this.dbContext.Set<Bank>().ToList();
        }

        public List<BudgetItemCategory> GetBudgetItemCategories()
        {
            return this.dbContext.Set<BudgetItemCategory>().ToList();
        }

        public IList<TransactionType> ReturnTransactionTypes()
        {
            return this.dbContext.Set<TransactionType>()
                .Include(x => x.TransactionTypeIdentifiers)
                .ToList();
        }
        
        public void Dispose() {
            disposableImplementation.Dispose();
        }
    }
}