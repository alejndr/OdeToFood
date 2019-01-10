﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
	public class InMemoryRestaurantData : IRestaurantData
	{
		public InMemoryRestaurantData()
		{
			_restaurants = new List<Restaurant>
			{
				new Restaurant {Id = 1, Name = "Scott's Lasagna Kingdom"},
				new Restaurant {Id = 2, Name = "Margaret Funny Pizzas"},
				new Restaurant {Id = 3, Name = "El wok de Lee"}
			};
		}

		

		public IEnumerable<Restaurant> GetAll()
		{
			return _restaurants.OrderBy(r => r.Name);
 		}

		List<Restaurant> _restaurants;
	}
}
