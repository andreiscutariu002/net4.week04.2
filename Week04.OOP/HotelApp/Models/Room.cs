namespace HotelApp.Models
{
    public class Room
    {
        public Room(int number, int adults, int children, Rate rate)
        {
            this.Number = number;
            this.Adults = adults;
            this.Children = children;
            this.Rate = rate;
        }

        public int Number { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public Rate Rate { get; set; }
    }
}
