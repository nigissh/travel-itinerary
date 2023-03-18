namespace Travel_Itinerary.Entity
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Destination Destination { get; set; }
        public int DestinationId { get; set; }
    }
}
