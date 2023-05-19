namespace DesignPatterns.ObserverPattern.DAL
{
    public class Discount
    {
        public int Id { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool Status { get; set; }
    }
}
