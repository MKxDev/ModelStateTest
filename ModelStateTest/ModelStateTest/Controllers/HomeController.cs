using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateTest.Models;

namespace ModelStateTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            var person = new Person
                {
                    Name = "John",
                    Address = new Address
                        {
                            Address1 = "123 Main St",
                        }
                };

            return View(person);
        }

        [HttpPost]
        public JsonResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Where(m => m.Value.Errors.Count > 0)
                    .ToDictionary(m => m.Key, m => m.Value.Errors.FirstOrDefault().ErrorMessage); 

                return Json(errors);
            }

            return Json(person);
        }
    }
}
