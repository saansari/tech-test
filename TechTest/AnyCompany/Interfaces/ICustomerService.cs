using AnyCompany;
using System.Collections.Generic;

namespace AnyCompany.Interfaces
{
	public interface ICustomerService
	{
		Customer GetCustomer(int customerId);

		List<Customer> GetAllCustomer();
	}
}

