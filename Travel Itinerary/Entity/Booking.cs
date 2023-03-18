namespace Travel_Itinerary.Entity
{
    public class Booking
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public Destination Destination { get; set; }
    }
}
