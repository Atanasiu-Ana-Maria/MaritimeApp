namespace MaritimeAPI.Models
{
    public class Voyage
    {
        public int VoyageId { get; set; }
        public DateTime VoyageDate { get; set; }
        public int DeparturePortId { get; set; }
        public int ArrivalPortId { get; set; }
        public DateTime VoyageStart { get; set; }
        public DateTime VoyageEnd { get; set; }
        public int ShipId { get; set; }
    }
}
