using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id=1,Name="El Picacho", Cuisine=CuisineType.Vallegrandina},
                new Restaurant{ Id=2,Name="La casa del camba", Cuisine=CuisineType.Bolivian},
                new Restaurant{ Id=3,Name="Scott's Pizza", Cuisine=CuisineType.Italian}
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r=>r.Name);
        }
    }
}
