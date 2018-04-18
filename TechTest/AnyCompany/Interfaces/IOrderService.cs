using AnyCompany;
using System.Collections.Generic;

namespace AnyCompany.Interfaces
{
	public interface IOrderService
	{
		bool PlaceOrder(Order order, string country);
		List<Order> GetOrders(List<int> orderIds);
	}
}

