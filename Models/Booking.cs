namespace SandwellHotels.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public string? CustomerName { get; set; }
        public DateTime? BookedDate { get; set; } = DateTime.Now;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
        //navigation property
        public HotelRoom? HotelRoom { get; set; }
    }
}
