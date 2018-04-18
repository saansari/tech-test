using AnyCompany.Interfaces;
using System.Collections.Generic;

namespace AnyCompany
{
    public class CustomerOrderService
    {
        private readonly IOrderService orderService;
        private readonly ICustomerService customerService;

        public CustomerOrderService(IOrderService orderService, ICustomerService customerService)
        {
            this.orderService = orderService;
            this.customerService = customerService;
        }

        public bool PlaceOrder(Order order, int customerId)
        {
            var customer = this.customerService.GetCustomer(customerId);
            return this.orderService.PlaceOrder(order, customer.Country);
        }

        public List<Customer> GetCustomerOrders()
        {
            var customers = this.customerService.GetAllCustomers();
            foreach (var customer in customers)
            {
                customer.Orders = this.orderService.GetOrders(customer.OrderIds);
            }

            return customers;
        }
    }
}
