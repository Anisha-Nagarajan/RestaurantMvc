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
        [StringLength(5, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 1)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email is Required. It cannot be empty")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is Required. It cannot be empty")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Address is Required. It cannot be empty")]
        [RegularExpression(@"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$", ErrorMessage = "Invalid City Name")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required. It cannot be empty")]
        public CustomerCity City { get; set; }
        [Required(ErrorMessage = "PhoneNumber is Required. It cannot be empty")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
        [StringLength(10, ErrorMessage = "The Mobile must contains 10 characters", MinimumLength = 10)]
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
