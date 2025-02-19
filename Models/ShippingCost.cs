namespace TrevioWepApp.Models
{
    public class ShippingCost
    {
        public required string City { get; set; }
        public decimal JneCost { get; set; }
        public decimal TikiCost { get; set; }
        public decimal PosCost { get; set; }
    }
}
