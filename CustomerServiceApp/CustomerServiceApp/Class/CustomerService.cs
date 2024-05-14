namespace CustomerServiceApp.Class
{
    public class CustomerService
    {

        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

    }
}
