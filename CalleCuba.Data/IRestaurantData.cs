using CalleCuba.Core;
using System.Collections.Generic;
using System.Linq;

namespace CalleCuba.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>() {
                new Restaurant { Id = 1, Name = "Calle Cuba Miami", Location = "Miami", Cuisine = CuisineType.Cuban },
                new Restaurant { Id = 2, Name = "Calle Cuba New York", Location = "New York", Cuisine = CuisineType.CubanVenezuelanFusion },
                new Restaurant { Id = 3, Name = "Calle Cuba Medellin", Location = "Medellin", Cuisine = CuisineType.CubanColombianFusion }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}