﻿using AnyCompany;
using System.Collections.Generic;

namespace AnyCompany.Interfaces
{
	public interface IOrderRepository
	{
		void Save(Order order);
		List<Order> GetOrders(List<int> orderIds);
	}
}

