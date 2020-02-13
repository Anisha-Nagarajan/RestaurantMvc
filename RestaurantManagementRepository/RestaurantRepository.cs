using RestaurantManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementRepository
{
    public class RestaurantRepository
    {
        public static List<RestaurantEntity> RestaurantDetails = new List<RestaurantEntity>();
        static RestaurantRepository()
        {
            RestaurantEntity restaurant;
            restaurant=new RestaurantEntity(1, "YumPlum", "Yumplum");
            RestaurantDetails.Add(restaurant);
            restaurant = new RestaurantEntity(2, "SpiceKing", "SpiceKing");
            RestaurantDetails.Add(restaurant);
        }
        public static IEnumerable<RestaurantEntity> Restaurants( )
        {
            return RestaurantDetails;
        }
    }
}
