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
        public ActionResult TechBox(int stranka)
        {
            www_africatwin_czEntities atDB = new www_africatwin_czEntities();

            var model = atDB.at_pokec.OrderByDescending(p => p.datum).Skip(stranka).Take(20);

            ViewBag.PocetPolozek = model.Count();
            
            return View(model);
        }
	}
}