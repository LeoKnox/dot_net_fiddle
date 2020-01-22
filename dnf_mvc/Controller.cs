using System;
using System.Web.Mvc;
using System.Collections.Generic;

namespace HelloWorldMvcApp
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			SampleViewModel TT = new SampleViewModel();
			TT.Test = "Test";
			return View(TT);
		}


		[HttpPost]
		public JsonResult GetAnswer(string question)
		{				
			int index = _rnd.Next(_db.Count);
			var answer = _db[index];
			return Json(answer);
		}

		private static Random _rnd = new Random();
		
		private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes"} ;
	}
}
