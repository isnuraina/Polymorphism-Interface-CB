using Service.Services.Implementations;
using Service.Services.Interfaces;

namespace ProgramDatabase.Controllers
{
	public class CategoryController
	{
		private readonly ICategoryService _categoryService;
		public CategoryController()
		{
			_categoryService=new CategoryService();
		}
		public void GetAll()
		{
			var result=_categoryService.GetAllCategories();
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}
		}
	}
}
