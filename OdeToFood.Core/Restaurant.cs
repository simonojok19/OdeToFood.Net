using System;

namespace OdeToFood.Core
{
    public enum CuisineType
    {
        None,
        Mexican,
        Italian,
        Indian
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
