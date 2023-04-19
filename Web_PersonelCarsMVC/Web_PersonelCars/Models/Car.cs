namespace Web_PersonelCars.Models
{
    public class Car
    {
        public Car()
        {
            this.CarId = _id++;
        }
        private static int _id = 0;
        public int CarId { get; private set; }

        public int ModelYear { get; set; }

        public string ModelName { get; set; }

        public Personel Personel { get; set; }

        public int PersonelId { get; set; }
    }
}
