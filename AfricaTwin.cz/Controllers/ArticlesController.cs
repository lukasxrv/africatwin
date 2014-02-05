using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AfricaTwin.cz.Models;

namespace AfricaTwin.cz.Controllers
{
    public class ArticlesController : Controller
    {
        private www_africatwin_czEntities db = new www_africatwin_czEntities();

        // GET: /Articles/
        public ActionResult Index()
        {
            return View(db.at_polozky.Where(p => p.active.Value == 1 && p.kategorie.Equals("clanek")).OrderByDescending(c => c.public_date).ToList());
        }

        // GET: /Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_polozky at_polozky = db.at_polozky.Find(id);
            if (at_polozky == null)
            {
                return HttpNotFound();
            }
            return View(at_polozky);
        }

        // GET: /Articles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="nadpis,text,title")] at_polozky at_polozky)
        {
            if (ModelState.IsValid)
            {
                db.at_polozky.Add(at_polozky);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(at_polozky);
        }

        // GET: /Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_polozky at_polozky = db.at_polozky.Find(id);
            if (at_polozky == null)
            {
                return HttpNotFound();
            }
            return View(at_polozky);
        }

        // POST: /Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="nadpis,text,title")] at_polozky at_polozky)
        {
            if (ModelState.IsValid)
            {
                db.Entry(at_polozky).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(at_polozky);
        }

        // GET: /Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_polozky at_polozky = db.at_polozky.Find(id);
            if (at_polozky == null)
            {
                return HttpNotFound();
            }
            return View(at_polozky);
        }

        // POST: /Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            at_polozky at_polozky = db.at_polozky.Find(id);
            db.at_polozky.Remove(at_polozky);
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
