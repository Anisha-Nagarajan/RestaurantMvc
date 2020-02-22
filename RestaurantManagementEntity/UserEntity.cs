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
        public string Password { get; set; }
        public UserEntity()
        {

        }
        public UserEntity(string name,string password)
        {
            this.Name = name;
            this.Password = password;
        }
    }
}
