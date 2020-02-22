using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagementEntity;
using static RestaurantManagementEntity.CustomerEntity;

namespace RestaurantManagementRepository
{
    public  class CustomerRepository
    {
        public static List<CustomerEntity> CustomerDetails = new List<CustomerEntity>();
        static CustomerRepository()
        {
            CustomerEntity customer;
            customer = new CustomerEntity(1, "Akhil", "aki123", "akhilnagarajan@gmail.com", "Male", "Anbu Nagar",(CustomerCity)Enum.Parse(typeof(CustomerCity), "Salem"), 8903723179);
            CustomerDetails.Add(customer);
            customer = new CustomerEntity(2, "Saranya", "saran123", "saranyanatarajan@gmail.com", "Female", "Gandhi Nagar", (CustomerCity)Enum.Parse(typeof(CustomerCity), "Salem"), 8903723179);
            CustomerDetails.Add(customer);
        }
        public static IEnumerable<CustomerEntity> Customers()
        {
             return CustomerDetails;
        }
        public static void Add(CustomerEntity customer)
        {
            CustomerDetails.Add(customer);
        }
        public static bool Login(UserEntity user)
        {
            bool loginStatus = false;
            foreach(CustomerEntity customer in CustomerDetails)
            {
                if ((user.Name.Equals(customer.Name)) && (user.Password.Equals(customer.Password)))
                {
                    loginStatus = true;
                    break;
                }
            }
            return loginStatus;
        }
    }
}
