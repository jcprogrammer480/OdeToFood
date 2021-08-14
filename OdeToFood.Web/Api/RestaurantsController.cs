using OdeToFood.Data.Models;
using OdeToFood.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        IRestaurantData _db;
        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }
        public IEnumerable<Restaurant> GET()
        {
            var restaurants = _db.GetAll();
            return restaurants;
        }
    }
}
