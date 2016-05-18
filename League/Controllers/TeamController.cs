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
    public class TeamController : Controller
    {
        // Initialise SERVICE object 
        ITeamService _TeamService;

        public TeamController(ITeamService TeamService)
        {
            _TeamService = TeamService;
        }

        // GET: /Team
        public ActionResult Index()
        {
            return View(_TeamService.GetAll());
        }

        // GET: /Team/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Team/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="TeamName,RoundWinner,ActiveFlag")]Team team)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _TeamService.Create(team);
                return RedirectToAction("Index");
            }
            return View(team);
        }

        // GET: /Team/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Team team = _TeamService.GetById(id.Value);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: /Team/Edit
        [HttpPost]
        public ActionResult Edit([Bind(Include="Id,TeamName,RoundWinner,ActiveFlag")]Team team)
        {
            if (ModelState.IsValid)
            {
                _TeamService.Update(team);
                return RedirectToAction("Index");
            }
            return View(team);
        }

        // GET: /Team/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Team team = _TeamService.GetById(id.Value);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: /Team/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, FormCollection data)
        {
            Team team = _TeamService.GetById(id);
            _TeamService.Delete(team);
            return RedirectToAction("Index");
        }
    }
}