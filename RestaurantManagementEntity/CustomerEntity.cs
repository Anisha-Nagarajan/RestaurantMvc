using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Id is Required. It cannot be empty")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{8,15}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 Alphabet and 1 Number")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is Required. It cannot be empty")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required. It cannot be empty")]
        public CustomerCity City { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
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
