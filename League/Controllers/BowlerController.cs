using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.Model;
using League.Service.Interfaces;
using System.Net;

namespace League.Controllers
{
    public class BowlerController : Controller
    {
        // initialise service object 
        IBowlerService _BowlerService;
        ITeamService   _TeamService;

        public BowlerController(IBowlerService BowlerService, ITeamService TeamService)
        {
            _BowlerService = BowlerService;
            _TeamService   = TeamService; 
        }

        // GET: /Bowler
        public ActionResult Index()
        {
            return View(_BowlerService.GetAll());
        }

        // GET: /Bowler/Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowler bowler = _BowlerService.GetById(id.Value);
            if (bowler == null)
            {
                return HttpNotFound();
            }

            return View(bowler);
        }

        // GET: /Bowler/Create
        public ActionResult Create()
        {
            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName");
            return View();
        }

        // POST: /Bowler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BowlerName,Address,Phone,PrivacyFlag,ActiveFlag,Gender,TeamId,Position,Email")]Bowler bowler)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _BowlerService.Create(bowler);
                return RedirectToAction("Index");
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", bowler.TeamId);
            return View(bowler);
        }

        // GET: /Bowler/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowler bowler = _BowlerService.GetById(id.Value);
            if (bowler == null)
            {
                return HttpNotFound();
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", bowler.TeamId);
            return View(bowler);
        }

        // POST: /Bowler/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, BowlerName, Address, Phone, PrivacyFlag, ActiveFlag, Gender, TeamId, Position, Email")]Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _BowlerService.Update(bowler);
                return RedirectToAction("Index");
            }

            ViewBag.TeamId = new SelectList(_TeamService.GetAll(), "Id", "TeamName", bowler.TeamId);
            return View(bowler);
        }

        // GET: /Bowler/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowler bowler = _BowlerService.GetById(id.Value);
            if (bowler == null)
            {
                return HttpNotFound();
            }

            return View(bowler);
        }

        // POST: /Bowler/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Bowler bowler = _BowlerService.GetById(id);
            _BowlerService.Delete(bowler);
            return RedirectToAction("Index");
        }
    }
}