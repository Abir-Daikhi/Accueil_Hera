using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccueilHera.Data;
using AccueilHera.Models;
namespace AccueilHera.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext db = new MyDBContext();
        //public Abonnement abonnements;
        public ActionResult Index()
        {
            //private static List<Abonnement> abonnements = new List<Abonnement>();
            //IList<Student> studentList = new List<Student>();
            //List<Abonnement> abonnementsList = new List<Abonnement>();
            //abonnementsList.Add(new Abonnement() { Nom_Abonnement = "Test" });
            //ViewData["abonnements"] = abonnementsList;

            //Abonnement abonnements = db.Abonnements.Find();


            //return View();
            return View(db.Abonnements.ToList());
        }

        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Register()
        {

            return View();
        }
    }
}