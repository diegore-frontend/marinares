namespace Marinares.Data.Shared.Payment
{
	public class ItemPayPal
	{
        public string Email { get; set; }
        public string Key { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Quantity { get; set; }
		public float Price { get; set; }
	}
}
