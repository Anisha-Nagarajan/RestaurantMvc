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
            restaurant=new RestaurantEntity(1, "YumPlum", "Yumplum cake factory");
            RestaurantDetails.Add(restaurant);
            restaurant = new RestaurantEntity(2, "SpiceKing", "SpiceKing is the King of Spices");
            RestaurantDetails.Add(restaurant);
        }
        public static IEnumerable<RestaurantEntity> Restaurants( )
        {
            return RestaurantDetails;
        }
        public static void Add(RestaurantEntity restaurant)
        {
            RestaurantDetails.Add(restaurant);
        }
        public static RestaurantEntity GetRestaurantById(int id)
        {
            return RestaurantDetails.Find(res => res.Id == id);
         
        }
        public static void Update(RestaurantEntity restaurant)
        {
            RestaurantEntity updatedRestaurant = RestaurantDetails.Find(res => res.Id == restaurant.Id);
            updatedRestaurant.Id = restaurant.Id;
            updatedRestaurant.Name = restaurant.Name;
            updatedRestaurant.Description = restaurant.Description;
        }
        public static void Delete(int resId)
        {
            RestaurantEntity restaurant = GetRestaurantById(resId);
            if (restaurant != null)
            {
                RestaurantDetails.Remove(restaurant);
            }
        }
    }
}
