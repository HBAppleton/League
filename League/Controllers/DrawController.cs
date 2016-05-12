using League.Service.Interfaces;
using League.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace League.Controllers
{
    public class DrawController : Controller
    {
        IDrawService _DrawService;
        IWeekService _WeekService;
        ITeamService _TeamService;
        public DrawController(IDrawService DrawService, IWeekService WeekService, ITeamService TeamService)
        {
            _DrawService = DrawService;
            _WeekService = WeekService;
            _TeamService = TeamService;
        }

        // GET: Draw
        public ActionResult Index()
        {
            return View(_DrawService.GetActive());
        }

        // GET: /Draw/Detail
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Draw draw = _DrawService.GetById(id.Value);
            if (draw == null)
            {
                return HttpNotFound();
            }

            return View(draw);
        }

        // GET: /Draw/Create
        public ActionResult Create()
        {
            ViewBag.WeekId = new SelectList(_WeekService.GetActive(), "Id", "WeekDate");
            ViewBag.TeamId = new SelectList(_TeamService.GetActive(), "Id", "TeamName");
            return View();
        }

        // POST: /Draw/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="Id,TeamId,WeekId,Lane,Pairing,Game1,Game2,Game3,Series,Bonus,Total,LegalLineup")] Draw draw)
        {
            if (ModelState.IsValid)
            {
                _DrawService.Create(draw);
                return RedirectToAction("Index");
            }

            ViewBag.WeekId = new SelectList(_WeekService.GetAll(), "Id", "WeekDate", draw.WeekId);
            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", draw.TeamId);
            return View(draw);
        }

        // GET: /Draw/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Draw draw = _DrawService.GetById(id.Value);
            if (draw == null)
            {
                return HttpNotFound();
            }

            ViewBag.WeekId = new SelectList(_WeekService.GetAll(), "Id", "WeekDate", draw.WeekId);
            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", draw.TeamId);
            return View(draw);
        }

        // POST: /Draw/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,TeamId,WeekId,Lane,Pairing,Game1,Game2,Game3,Series,Bonus,Total,LegalLineup")] Draw draw)
        {
            if (ModelState.IsValid)
            {
                _DrawService.Update(draw);
                return RedirectToAction("Index");
            }

            ViewBag.WeekId = new SelectList(_WeekService.GetAll(), "Id", "WeekDate", draw.WeekId);
            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", draw.TeamId);
            return View(draw);
        }

        // GET: /Draw/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Draw draw = _DrawService.GetById(id.Value);
            if (draw == null)
            {
                return HttpNotFound();
            }

            return View(draw);
        }

        // POST: /Draw/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Draw draw = _DrawService.GetById(id);
            _DrawService.Delete(draw);
            return RedirectToAction("Index");
        }
    }
}