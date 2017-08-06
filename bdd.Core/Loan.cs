namespace bdd.Core
{
    public class Loan
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
        public string PropertyAddress { get; set; }
        public int ProductId { get; set; }
        public string ProductGroup { get; set; }
        public int PurchasePrice { get; set; }
    }
}