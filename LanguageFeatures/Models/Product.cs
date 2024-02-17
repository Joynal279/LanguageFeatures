using System;
namespace LanguageFeatures.Models
{
	public class Product
	{
		public string Name { get; set; }
		public decimal? Price { get; set; }

		public static Product[] GetProducts()
		{
			Product kayak = new Product
			{
				Name = "kayak",
				Price = 275M
			};

			Product lifeJacket = new Product
			{
				Name = "Lifejacket",
				Price = 33.4M
			};

			return new Product[] { kayak, lifeJacket, null };
		}
	}
}

