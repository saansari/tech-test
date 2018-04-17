using AnyCompany.Interfaces;

namespace AnyCompany
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomer(int customerId)
        {
            return CustomerRepository.Load(customerId);
        }

        public List<Customer> GetAllCustomer()
        {
            return CustomerRepository.LoadAll();
        }
    }
}
