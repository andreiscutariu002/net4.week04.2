namespace HotelApp
{
    using System.Collections.Generic;
    using Models;

    public class HotelManager
    {
        private readonly List<Hotel> hotels;

        public HotelManager()
        {
            this.hotels = new List<Hotel>();
        }

        public void Add(Hotel hotel1)
        {
            this.hotels.Add(hotel1);
        }
    }
}
