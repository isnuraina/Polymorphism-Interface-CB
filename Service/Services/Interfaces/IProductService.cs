using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IProductService
	{
		int FindCount();
		Product GetNameProduct(string productName);
		Product[] GetAllProducts();
		double AvarageProductPrice();
	}

}
