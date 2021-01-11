using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AccueilHera.Data;
using AccueilHera.Models;

namespace AccueilHera.Controllers
{
    public class AbonnementsController : Controller
    {
        private MyDBContext db = new MyDBContext();
        

        // GET: Abonnements
        public ActionResult Index()
        {
            return View(db.Abonnements.ToList());
        }

        // GET: Abonnements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abonnement abonnement = db.Abonnements.Find(id);
            if (abonnement == null)
            {
                return HttpNotFound();
            }
            return View(abonnement);
        }

        // GET: Abonnements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Abonnements/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Abonnement,Nom_Abonnement,Description_Abonnement,Prix_Abonnement,Statut_Abonnement")] Abonnement abonnement)
        {
            if (ModelState.IsValid)
            {
                db.Abonnements.Add(abonnement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abonnement);
        }

        // GET: Abonnements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abonnement abonnement = db.Abonnements.Find(id);
            if (abonnement == null)
            {
                return HttpNotFound();
            }
            return View(abonnement);
        }

        // POST: Abonnements/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Abonnement,Nom_Abonnement,Description_Abonnement,Prix_Abonnement,Statut_Abonnement")] Abonnement abonnement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abonnement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abonnement);
        }

        // GET: Abonnements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abonnement abonnement = db.Abonnements.Find(id);
            if (abonnement == null)
            {
                return HttpNotFound();
            }
            return View(abonnement);
        }

        // POST: Abonnements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Abonnement abonnement = db.Abonnements.Find(id);
            db.Abonnements.Remove(abonnement);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
