
namespace Domain.Models
{
	public class Category:BaseEntity
	{
		public string Name { get; set; }
		public static int Count { get; set; }
		public DateTime CreatedDate { get; set; }

		public Category(string name)
		{
			Id = ++Count;
			Name = name;
			CreatedDate = DateTime.Now;
		}
		public override string ToString()
		{
			return $"Id:{Id}\nName:{Name}\nCreatedDate:{CreatedDate}\n" +
				$"---------------------------------------------------";
		}
	}
}
