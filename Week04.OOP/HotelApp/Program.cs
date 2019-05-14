namespace HotelApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hotelCreator = new HotelCreator();
            var hotelManager = new HotelManager();

            var hotel1 = hotelCreator.CreateAHotel();
            hotelManager.Add(hotel1);
        }
    }
}
