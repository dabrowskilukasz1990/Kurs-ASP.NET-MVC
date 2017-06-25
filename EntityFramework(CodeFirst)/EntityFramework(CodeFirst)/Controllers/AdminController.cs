using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityFramework_CodeFirst_.DAL;
using EntityFramework_CodeFirst_.Models;

namespace EntityFramework_CodeFirst_.Controllers
{
    public class AdminController : Controller
    {
        private KontaktyContext db = new KontaktyContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Kontakty.ToList());
        }

        // GET: Admin/Szczegoly/5
        public ActionResult Szczegoly(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontakt kontakt = db.Kontakty.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        // GET: Admin/Stworz
        public ActionResult Stworz()
        {
            return View();
        }

        // POST: Admin/Stworz
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Stworz([Bind(Include = "KontaktId,Imie,Nazwisko,Email,NowePole,Pytanie")] Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                db.Kontakty.Add(kontakt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kontakt);
        }

        // GET: Admin/Edytuj/5
        public ActionResult Edytuj(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontakt kontakt = db.Kontakty.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        // POST: Admin/Edytuj/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edytuj([Bind(Include = "KontaktId,Imie,Nazwisko,Email,NowePole,Pytanie")] Kontakt kontakt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kontakt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kontakt);
        }

        // GET: Admin/Usun/5
        public ActionResult Usun(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kontakt kontakt = db.Kontakty.Find(id);
            if (kontakt == null)
            {
                return HttpNotFound();
            }
            return View(kontakt);
        }

        // POST: Admin/Usun/5
        [HttpPost, ActionName("Usun")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kontakt kontakt = db.Kontakty.Find(id);
            db.Kontakty.Remove(kontakt);
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
