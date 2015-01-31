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
    public class ActionsController : Controller
    {
        private www_africatwin_czEntities db = new www_africatwin_czEntities();

        // GET: /Actions/
        public ActionResult Index()
        {
            return View(db.at_akce.ToList());
        }

        // GET: /Actions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_akce at_akce = db.at_akce.Find(id);
            if (at_akce == null)
            {
                return HttpNotFound();
            }
            return View(at_akce);
        }

        // GET: /Actions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Actions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id_akce,nazev,povidani,id_kamene,termin_od,termin_do,insert_date,user_id,username,upoutavka,uzavreno,formular,formular_dny,formular_bydleni,formular_jezdeni,data_1,data_2,data_3,data_4,data_5,data_6,data_7,formular_penze,formular_deti")] at_akce at_akce)
        {
            if (ModelState.IsValid)
            {
                db.at_akce.Add(at_akce);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(at_akce);
        }

        // GET: /Actions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_akce at_akce = db.at_akce.Find(id);
            if (at_akce == null)
            {
                return HttpNotFound();
            }
            return View(at_akce);
        }

        // POST: /Actions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id_akce,nazev,povidani,id_kamene,termin_od,termin_do,insert_date,user_id,username,upoutavka,uzavreno,formular,formular_dny,formular_bydleni,formular_jezdeni,data_1,data_2,data_3,data_4,data_5,data_6,data_7,formular_penze,formular_deti")] at_akce at_akce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(at_akce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(at_akce);
        }

        // GET: /Actions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            at_akce at_akce = db.at_akce.Find(id);
            if (at_akce == null)
            {
                return HttpNotFound();
            }
            return View(at_akce);
        }

        // POST: /Actions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            at_akce at_akce = db.at_akce.Find(id);
            db.at_akce.Remove(at_akce);
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
