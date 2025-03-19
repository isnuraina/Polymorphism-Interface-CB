namespace Domain.Models
{
	public class Product:BaseEntity
	{
		
		public string Name { get; set; }
		public double Price { get; set; }
		public DateTime CreatedDate { get; set; }
		public static int Counter { get; set; }
		public Category Category { get; set; }

		public Product(string name, double price,Category category)
		{
			Id = ++Counter;
			Name = name;
			Price = price;
			CreatedDate = DateTime.Now;
			Category = category;
		}
		public override string ToString()
		{
			return $"Id:{Id}\nName:{Name}\nPrice:{Price}\nCreatedDate:{CreatedDate}\n" +
				$"Category Name:{Category.Name}\n" +
				$"---------------------------------------------";
		}

	}
}
