using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalleCuba.Core;
using CalleCuba.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalleCuba.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;

        public Restaurant Restaurant { get; set; }

        public EditModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = _restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}