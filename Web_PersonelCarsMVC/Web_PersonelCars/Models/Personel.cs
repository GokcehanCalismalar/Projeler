namespace Web_PersonelCars.Models
{
	public class Personel
	{
		public Personel()
		{
			this.PersonelId = _id++;
		}
		private static int _id = 0;
		public int PersonelId { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public List<Car> Cars { get; set; } = new();
	}
}
