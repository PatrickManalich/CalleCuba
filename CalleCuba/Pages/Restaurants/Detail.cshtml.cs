using CalleCuba.Core;
using CalleCuba.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalleCuba.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public void OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetById(restaurantId);
        }
    }
}