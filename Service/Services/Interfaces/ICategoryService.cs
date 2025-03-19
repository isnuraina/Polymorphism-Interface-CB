
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface ICategoryService
	{
		Category[]GetAllCategories();
		Category GetById(int id);
		

	}
}
