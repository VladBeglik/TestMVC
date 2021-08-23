using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestMVC.Models;

namespace TestMVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Good" : "Bad";
			return View();
		}

		[HttpGet]
		public IActionResult RegistrationForm()
		{
			return View();
		}

		[HttpPost]
		public IActionResult RegistrationForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid)
			{
				Repository.AddResponse(guestResponse);
				return View("Thanks", guestResponse);
			}
			else
			{
				return View();
			}
		}


		public IActionResult ListGuests()
		{
			return View(Repository.Responses.Where(r => r.WillAttend == true));
		}
	}
}
