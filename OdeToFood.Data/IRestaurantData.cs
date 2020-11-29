using OdeToFood.Core;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OdeToFood.Data
{

    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestuarantData : IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
