using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Sara.Api.Models;

namespace Sara.Api.Controllers
{
    public class AreaController : ApiController
    {
        DataContext db = new DataContext();

		public IEnumerable<Area> Get()
		{
            return db.Areas.ToList();		
        }

        public Area Get(int id)
		{
            return db.Areas.Find(id);
		}


		/**

        [System.Web.Http.HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        **/
	}
}