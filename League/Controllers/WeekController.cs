using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.Model;
using League.Service;
using System.Net;

namespace League.Controllers
{
    public class WeekController : Controller
    {
        // Initialise SERVICE object 
        IWeekService _weekService;

        public WeekController(IWeekService weekService)
        {
            _weekService = weekService;
        }

        // GET: /Week
        public ActionResult Index()
        {
            return View(_weekService.GetAll());
        }

        // GET: /Week
        public ActionResult Active()
        {
            return View(_weekService.GetActive());
        }

        // GET: /Week/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Week/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeekDate,WeekNumber,Season")] Week week)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _weekService.Create(week);
                return RedirectToAction("Active");
            }
            return View(week);
        }

        // GET: /Week/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Week week = _weekService.GetById(id.Value);
            if (week == null)
            {
                return HttpNotFound();
            }
            return View(week);
        }

        // POST: /Week/Edit
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,WeekDate,WeekNumber,Season")]Week week)
        {
            if (ModelState.IsValid)
            {
                _weekService.Update(week);
                return RedirectToAction("Active");
            }
            return View(week);
        }

        // GET: /Week/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Week week = _weekService.GetById(id.Value);
            if (week == null)
            {
                return HttpNotFound();
            }
            return View(week);
        }

        // POST: /Week/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, FormCollection data)
        {
            Week week = _weekService.GetById(id);
            _weekService.Delete(week);
            return RedirectToAction("Active");
        }
    }
}