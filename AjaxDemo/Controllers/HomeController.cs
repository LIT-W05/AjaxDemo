using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IsAvailable(string email)
        {
            bool isAvailable = email != "foo@bar.com" && email != "hello@world.com";
            var response = new AvailableResponse { Available = isAvailable, Stuff = "Avrumi" };
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reverse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reverse(string text)
        {
            string reversed = new string(text.Reverse().ToArray());
            return Json(new { ReversedText = reversed });
        }

        public ActionResult People()
        {
            return View();
        }

        public ActionResult GetPerson()
        {
            return Json(GeneratePerson(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetPeople()
        {
            var people = new List<Person>();
            for (int i = 1; i <= 10; i++)
            {
                people.Add(GeneratePerson());
            }

            return Json(people, JsonRequestBehavior.AllowGet);
        }

        public void Delete(int id)
        {
            //do delete.....
        }

        private Person GeneratePerson()
        {
            return new Person
            {
                FirstName = Faker.NameFaker.FirstName(),
                LastName = Faker.NameFaker.LastName(),
                Age = Faker.NumberFaker.Number(20, 100)
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class AvailableResponse
    {
        public string Stuff { get; set; }
        public bool Available { get; set; }
    }

}
//Create an application that has two textboxes and a button. When the user clicks on the button,
//take the text from the first textbox, and via ajax send it to the server (do it as a post)
//The server (C#) should then reverse that text, and respond (via Json) with an object that
//has a property on it called "ReversedText" that has the original text reversed. Back in your
//javascript, take this reversed text, and put it into the second textbox.