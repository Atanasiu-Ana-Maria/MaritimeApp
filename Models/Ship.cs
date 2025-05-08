namespace MaritimeAPI.Models
{
    public class Ship
    {
        public int ShipId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal MaxSpeed { get; set; }
    }
}
