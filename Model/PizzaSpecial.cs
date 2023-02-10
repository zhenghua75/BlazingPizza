﻿namespace BlazingPizza
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    ///披萨特价商品
    /// </summary>
    public class PizzaSpecial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
