using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalleCuba.Core;
using CalleCuba.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace CalleCuba.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IRestaurantData _restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            _config = config;
            _restaurantData = restaurantData;
        }

        public void OnGet()
        {
            Message = _config["Message"];
            Restaurants = _restaurantData.GetAll();
        }
    }
}