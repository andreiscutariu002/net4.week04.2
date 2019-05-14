namespace HotelApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hotelCreator = new HotelCreator();
            var hotelManager = new HotelManager();

            var hotel1 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel1);

            var hotel2 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel2);

            var hotel3 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel3);

            hotelManager.DeleteHotelFromCity(hotel1.Name, hotel3.City);
        }
    }
}
