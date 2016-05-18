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
    public class ScoresheetController : Controller
    {
        IScoresheetService _ScoresheetService;
        IDrawService _DrawService;
        IBowlerService _BowlerService;
        public ScoresheetController(IScoresheetService ScoresheetService, IDrawService DrawService, IBowlerService BowlerService)
        {
            _ScoresheetService = ScoresheetService;
            _DrawService = DrawService;
            _BowlerService = BowlerService;
        }

        // GET: Scoresheet
        public ActionResult Index()
        {
            return View(_ScoresheetService.GetAll());
        }

        // GET: Scoresheet/Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Scoresheet scoresheet = _ScoresheetService.GetById(id.Value);
            if (scoresheet == null)
            {
                return HttpNotFound();
            }

            return View(scoresheet);
        }

        // GET: Scoresheet/Create
        public ActionResult Create()
        {
            ViewBag.BowlerId = new SelectList(_BowlerService.GetActive(), "Id", "BowlerName");
            return View();
        }

        // POST: Scoresheet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="BowlerId,DrawId,Blindscore,Handicap,Game1,Game2,Game3")] Scoresheet scoresheet)
        {
            if (ModelState.IsValid)
            {
                _ScoresheetService.Create(scoresheet);
                return RedirectToAction("Index");
            }

            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", scoresheet.BowlerId);
            return View(scoresheet);
        }

        // GET: Scoresheet/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Scoresheet scoresheet = _ScoresheetService.GetById(id.Value);
            if (scoresheet == null)
            {
                return HttpNotFound();
            }

            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", scoresheet.BowlerId);
            return View(scoresheet);
        }

        // POST: Scoresheet/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,BowlerId,DrawId,BlindScore,Handicap,Game1,Game2,Game3")] Scoresheet scoresheet)
        {
            if (ModelState.IsValid)
            {
                _ScoresheetService.Update(scoresheet);
                return RedirectToAction("Index");
            }

            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", scoresheet.BowlerId);
            return View(scoresheet);
        }

        // GET: Scoresheet/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Scoresheet scoresheet = _ScoresheetService.GetById(id.Value);
            if (scoresheet == null)
            {
                return HttpNotFound();
            }

            return View(scoresheet);
        }

        // POST: Scoresheet/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Scoresheet scoresheet = _ScoresheetService.GetById(id);
            _ScoresheetService.Delete(scoresheet);
            return RedirectToAction("Index");
        }
    }
}