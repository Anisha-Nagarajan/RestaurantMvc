using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagementEntity;

namespace RestaurantManagementRepository
{
    public  class CustomerRepository
    {
        public static List<CustomerEntity> CustomerDetails = new List<CustomerEntity>();
        static CustomerRepository()
        {
            CustomerEntity customer;
            customer = new CustomerEntity(1,"Akhil","aki123","akhilnagarajan@gmail.com","Male","Anbu Nagar","Salem",8903723179);
            CustomerDetails.Add(customer);
            customer = new CustomerEntity(2,"Saranya", "saran123","saranyanatarajan@gmail.com", "Female", "Gandhi Nagar", "Salem",8903723179);
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
    }
}
