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
    public class TeamNoteController : Controller
    {
        ITeamNoteService _TeamNoteService;
        ITeamService _TeamService;
        public TeamNoteController(ITeamNoteService TeamNoteService, ITeamService TeamService)
        {
            _TeamNoteService = TeamNoteService;
            _TeamService     = TeamService;
        }

        // GET: TeamNote
        public ActionResult Index()
        {
            return View(_TeamNoteService.GetActive());
        }

        // GET: /TeamNote/Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Teamnote teamnote = _TeamNoteService.GetById(id.Value);
            if (teamnote == null)
            {
                return HttpNotFound();
            }

            return View(teamnote);
        }

        // GET: /TeamNote/Create
        public ActionResult Create()
        {
            ViewBag.TeamId = new SelectList(_TeamService.GetActive(), "Id", "TeamName");
            return View();
        }

        // POST: /TeamNote/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include ="TeamId,Season,Note,Rank")]Teamnote teamnote)
        {
            if (ModelState.IsValid)
            {
                _TeamNoteService.Create(teamnote);
                return RedirectToAction("Index");
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", teamnote.TeamId);
            return View(teamnote);
        }

        // GET: /TeamNote/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Teamnote teamnote = _TeamNoteService.GetById(id.Value);
            if (teamnote == null)
            {
                return HttpNotFound();
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", teamnote.TeamId);
            return View(teamnote);
        }

        // POST: /TeamNote/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,TeamId,Season,Note,Rank")] Teamnote teamnote)
        {
            if (ModelState.IsValid)
            {
                _TeamNoteService.Update(teamnote);
                return RedirectToAction("Index");
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", teamnote.TeamId);
            return View(teamnote);
        }

        // GET: /TeamNote/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Teamnote teamnote = _TeamNoteService.GetById(id.Value);
            if (teamnote == null)
            {
                return HttpNotFound();
            }

            return View(teamnote);
        }

        // POST: /TeamNote/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Teamnote teamnote = _TeamNoteService.GetById(id);
            _TeamNoteService.Delete(teamnote);
            return RedirectToAction("Index");
        }
    }
}