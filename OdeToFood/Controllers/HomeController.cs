using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		private IRestaurantData _restaurantData;
		private IGreeter _greeter;

		public HomeController(IRestaurantData restaurantData,
							  IGreeter greeter)
		{
			_restaurantData = restaurantData;
			_greeter = greeter;
		}

		public IActionResult Index()
		{
			var model = new HomeIndexViewModel();
			model.Restaurants = _restaurantData.GetAll();
			model.CurentMessage = _greeter.GetMessageOfTheDay();

			return View(model);
		}

		public IActionResult Details(int id)
		{
			var model = _restaurantData.Get(id);

			if (model == null)
			{
				return RedirectToAction(nameof(Index));
			}

			return View(model);
		}

		public IActionResult Create()
		{
			return View();
		}
	}
}
