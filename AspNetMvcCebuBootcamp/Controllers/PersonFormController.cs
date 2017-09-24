using AspNetMvcCebuBootcamp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcCebuBootcamp.Controllers
{
    public class PersonForm {
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
    }

    public class PersonFormController : Controller
    {

        // GET: PersonForm
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Details(PersonForm model) {
            return View(model);
        }

        public ActionResult ListOfPeople() {
            var list = new List<PersonForm>();

            for (int i = 0; i < 5; i++) {
                list.Add(new PersonForm() {
                    Fname = "PersonFname"+i,
                    Mname="",
                    Lname="Lastname"+i
                });
            }

            var finalList = list.Where(x => x.Fname == "Sonny");

            return View(list);
        }
        
    }
}
