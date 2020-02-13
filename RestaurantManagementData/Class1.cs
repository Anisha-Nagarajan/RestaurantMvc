using RestaurantManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementData
{
    public class RestaurantData
    {
        public static List<RestaurantEntity> RestaurantDetails = new List<RestaurantEntity>();
        public RestaurantData()
        {
            RestaurantEntity restaurant = new RestaurantEntity(1, "YumPlum", "Yumplum is famous for Cakes");
        }
    }
}
