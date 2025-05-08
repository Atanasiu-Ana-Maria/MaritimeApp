namespace MaritimeAPI.Models
{
    public class CountryVisited
    {
        public int CountryVisitedId { get; set; }
        public string CountryName { get; set; } = string.Empty;
        public DateTime VisitDate { get; set; }
    }
}
