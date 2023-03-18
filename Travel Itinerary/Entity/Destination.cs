namespace Travel_Itinerary.Entity
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }
    }
}
