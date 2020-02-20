using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RestaurantManagementEntity
{
    public class UserEntity
    {
        [Required(ErrorMessage = "Name is Required. It cannot be empty")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Password is Required. It cannot be empty")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)\S{8,15}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 Alphabet and 1 Number")]
        public string Password { get; set; }
        public UserEntity()
        {

        }
        public UserEntity(string Name, string Password)
        {
            this.Name = Name;
            this.Password = Password;
        }
    }
   
}
