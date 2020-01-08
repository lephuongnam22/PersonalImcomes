namespace PersonalIncomeStatement.Models.Enums
{
    public class ExpenseDetailModel
    {
        public string Date { get; set; }
        public string Money { get; set; }

        public string Description { get; set; }

        public ExpenseType ExpenseType { get; set; }
    }
}
