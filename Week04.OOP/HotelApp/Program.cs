namespace HotelApp
{
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            var hotelCreator = new HotelCreator();
            var hotelManager = new HotelManager();

            // add hotels
            var hotel1 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel1);

            var hotel2 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel2);

            var hotel3 = hotelCreator.CreateAHotel();
            hotelManager.AddHotel(hotel3);

            // delete hotel
            hotelManager.PrintHotels();
            hotelManager.DeleteHotelFromCity(hotel1.Name, hotel1.City);
            hotelManager.PrintHotels();

            // rooms below amount
            Console.Write("Enter the min amount for rooms: ");
            int amount = int.Parse(Console.ReadLine());
            hotelManager.ShowRoomsBelow(amount);
        }
    }
}
