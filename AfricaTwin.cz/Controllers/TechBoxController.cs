using AfricaTwin.cz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AfricaTwin.cz.Controllers
{
    public class TechBoxController : Controller
    {
        //
        // GET: /TechBox/
        public ActionResult TechBox()
        {
            www_africatwin_czEntities atDB = new www_africatwin_czEntities();

            int pocetZaznamuTechBoxu = atDB.at_polozky.Where(p => p.kategorie.StartsWith("techbox")).Count();

            ViewBag.PocetPolozek = pocetZaznamuTechBoxu;
            
            return View();
        }
	}
}