using Domain.Models;
using Service.Services.Implementations;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDatabase.Controllers
{
	public class ProductController
	{
		private readonly IProductService _productService;
		public ProductController()
		{
			_productService=new ProductService();
		}
		public void FindProductCount()
		{
			Console.WriteLine($"Count:{_productService.FindCount()}");
		}
		public void SearchProduct()
		{
			Console.Write("Enter searched product name:");
			string searchedProductName;
			searchedProductName = Console.ReadLine();
			Product product=_productService.GetNameProduct(searchedProductName);
			if (product!=null)
			{
				Console.WriteLine(product);
			}
			else
			{
				Console.WriteLine("Product not found!");
			}
		}
		public void GetAllProducts()
		{
			var result=_productService.GetAllProducts();
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
		public void AvarageProductPrice()
		{
			double avaragePrice=_productService.AvarageProductPrice();
			Console.WriteLine($"All products avarage price:{avaragePrice}");
		}
	}
}
