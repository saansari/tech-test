using AnyCompany.Interfaces;

namespace AnyCompany
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly IVATProvider vatProvider;

        public OrderService(IOrderRepository orderRepository, IVATProvider vatProvider)
        {
            this.orderRepository = orderRepository;
            this.vatProvider = vatProvider;
        }

        public bool PlaceOrder(Order order, string country)
        {
            if (order.Amount == 0)
                return false;

            var vatValue = this.vatProvider.GetVAT(country);
            order.VAT = vatValue;
            orderRepository.Save(order);

            return true;
        }

        public List<Order> GetOrders(List<int> orderIds)
        {
            return this.orderRepository.GetOrders(orderIds);
        }
    }
}
