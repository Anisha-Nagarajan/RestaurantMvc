using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementEntity
{
    public class RestaurantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public RestaurantEntity(int Id,string Name,string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
        }
    }
}
