using Domain.Models;
using Service.Services.Interfaces;
using System.Security.Cryptography;

namespace Service.Services.Implementations
{
	public class CategoryService : ICategoryService
	{
		private Category[] Categories()
		{
			Category c1 = new Category("C1");
			Category c2 = new Category("C2");
			Category c3 = new Category("C3");
			Category[] categories = new Category[] { c1, c2, c3 };
			return categories;

		}
		public Category[] GetAllCategories()
		{
			return Categories();
		}

		public Category GetById(int id)
		{
			Category exsistCategory=Categories().FirstOrDefault(c => c.Id == id);
			return exsistCategory;
		}
	}
}
