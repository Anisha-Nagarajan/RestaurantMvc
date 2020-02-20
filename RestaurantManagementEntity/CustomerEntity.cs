using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementEntity
{
   public class CustomerEntity
    {

        public enum CustomerCity
        {
            Salem,
            Namakkal,
            Erode,
            Tiruchengode,
            Coimbatore,
            Chennai
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public CustomerCity City { get; set; }
        public long PhoneNumber { get; set; }
        public CustomerEntity()
        {

        }
        public CustomerEntity(int Id, string Name,string Password,string Email,string Gender,string Address, CustomerCity City,long PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Gender = Gender;
            this.Address = Address;
            this.City = City;
            this.PhoneNumber = PhoneNumber;
        }

       
    }
    
}
