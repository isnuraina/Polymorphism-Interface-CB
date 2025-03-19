using Domain.Models;
using Service.Services.Interfaces;

namespace Service.Services.Implementations
{
	public class ProductService : IProductService
	{
		private Product[] Products() {
			Product p1 = new Product("Pamidor", 2, new Category("C1"));
			Product p2 = new Product("Xiyar", 2.5, new Category("C2"));
			Product p3 = new Product("Kartof", 0.8, new Category("C3"));
			Product p4 = new Product("Badimcan", 4.5, new Category("C4"));
			Product[] products = new Product[] { p1, p2, p3,p4 };
			return products;
		}
		public int FindCount()
		{
			int count = 0;
			var result = GetAllProducts();
			foreach (var item in result) { 
				count++;
			}
			return count;
		}

		public Product GetNameProduct(string productName)
		{
			var result=GetAllProducts();
			Product newProduct=result.FirstOrDefault(product => product.Name.ToLower().Trim() == productName.ToLower().Trim());
			return newProduct;
		}

		public Product[] GetAllProducts()
		{
			return Products();
		}

		public double AvarageProductPrice()
		{
			double avaragePrice = 0;
			int counter = 0;
			var result= GetAllProducts();
			foreach (var item in result) { 
				avaragePrice += item.Price;	
				counter++;
			}
			return avaragePrice/counter;
		}
	}
}
