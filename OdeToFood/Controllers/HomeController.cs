using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		private IRestaurantData _restaurantData;

		public HomeController(IRestaurantData restaurantData)
		{
			_restaurantData = restaurantData;
		}

		public IActionResult Index()
		{
			var model = new Restaurant { Id = 1, Name = "Scott's lasagna" };

			return View(model);
		}
	}
}
