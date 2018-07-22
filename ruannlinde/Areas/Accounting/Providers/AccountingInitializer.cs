namespace RL.Areas.Accounting.Providers {
    using System.Collections.Generic;
    using System.Data.Entity;

    using RL.Areas.Accounting.Models;

    public class AccountingInitializer : DropCreateDatabaseIfModelChanges<AccountingContext> {
        protected override void Seed(AccountingContext accounting) {

            var banks = new List<Bank> {
                                           new Bank { Name   = "ABSA", ImageSource          = "Content//images//standardbank.png" }
                                           , new Bank { Name = "Capitec", ImageSource       = "Content//images//capitec.png" }
                                           , new Bank { Name = "FNB", ImageSource           = "Content//images//fnb.png" }
                                           , new Bank { Name = "Nedbank", ImageSource       = "Content//images//nedbank.png" }
                                           , new Bank { Name = "Standard Bank", ImageSource = "Content//images//standardbank.png" }
                                       };
            var budgetItemCategories = new List<BudgetItemCategory> {
                                                                        new BudgetItemCategory { BudgetItemCategoryName   = "Banking" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Charities" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Education" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Entertainment" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Financial Services" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Family And Friends" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "General" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Health And Beauty" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Holiday Expenses" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Household Maintenance" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Insurance" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Internet Service Providers" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Investments" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Legal Services" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Medical" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Motoring" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Municipalities" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "OffShore" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Personal Services" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Property" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Rental Agencies" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Rent / Levies" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Retailers" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Salaries" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Scheduled Pre-paid" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Security Services" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Staff Costs" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Tax" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Telecommunications" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Traffic Departments" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Transport" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Travel" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Unemployment Insurance" }
                                                                        , new BudgetItemCategory { BudgetItemCategoryName = "Utilities" }
                                                                    };
            var transactionTypes = new List<TransactionType> {
                                                                 new TransactionType { TransactionTypeName   = "Bank Card Purchase" }
                                                                 , new TransactionType { TransactionTypeName = "Bank Charges" }
                                                                 , new TransactionType { TransactionTypeName = "Bank Transfer" }
                                                                 , new TransactionType { TransactionTypeName = "Budget Item" }
                                                                 , new TransactionType { TransactionTypeName = "Cash Withdrawal" }
                                                                 , new TransactionType { TransactionTypeName = "Credits" }
                                                                 , new TransactionType { TransactionTypeName = "Salaries" }
                                                                 , new TransactionType { TransactionTypeName = "Debt Repayment" }
                                                                 , new TransactionType { TransactionTypeName = "Fuel" }
                                                                 , new TransactionType { TransactionTypeName = "Failed TransactionEntry" }
                                                                 , new TransactionType { TransactionTypeName = "Failed TransactionEntry Reversal" }
                                                                 , new TransactionType { TransactionTypeName = "Medical Payments" }
                                                             };
            var retailers = new List<Retailer> {
                                                   new Retailer { RetailerName   = "Caltex" }
                                                   , new Retailer { RetailerName = "Checkers" }
                                                   , new Retailer { RetailerName = "Builders Warehouse" }
                                                   , new Retailer { RetailerName = "Dis-Chem" }
                                                   , new Retailer { RetailerName = "Engen" }
                                                   , new Retailer { RetailerName = "MBT" }
                                                   , new Retailer { RetailerName = "Pick & Pay" }
                                                   , new Retailer { RetailerName = "Spar" }
                                                   , new Retailer { RetailerName = "KFC" }
                                                   , new Retailer { RetailerName = "Liquor Store" }
                                                   , new Retailer { RetailerName = "Toll Gate" }
                                                   , new Retailer { RetailerName = "Pharmacy" }
                                                   , new Retailer { RetailerName = "Steers" }
                                                   , new Retailer { RetailerName = "Clicks" }
                                                   , new Retailer { RetailerName = "Wimpy" }
                                                   , new Retailer { RetailerName = "Twisp" }
                                                   , new Retailer { RetailerName = "Animal Kingdom" }
                                                   , new Retailer { RetailerName = "Barcelos" }
                                                   , new Retailer { RetailerName = "Gautrain" }
                                               };

            banks.ForEach(x => accounting.Banks.Add(x));
            budgetItemCategories.ForEach(x => accounting.BudgetItemCategories.Add(x));
            transactionTypes.ForEach(x => accounting.TransactionTypes.Add(x));
            retailers.ForEach(x => accounting.Retailer.Add(x));

            accounting.SaveChanges();
        }
    }
}