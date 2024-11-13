namespace SandwellHotels.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }//Room ID
        public required string Name { get; set; }//The name of the room
        public required string Location { get; set; }//The location of the room
        public double PricePerNight { get; set; }//THe price per night of the room
        public int StarRating { get; set; }//The star rating of the room
        public double GuestRating { get; set; }//The guest rating of the room
        public int NumberOfBed { get; set; }//The number of beds in the room
        public bool IsAvailable { get; set; } = true;//Is the room available
        public ICollection<Booking>? Bookings { get; set; }
    }
}
