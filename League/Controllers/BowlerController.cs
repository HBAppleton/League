using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.Model;
using League.Service.Interfaces;

namespace League.Controllers
{
    public class BowlerController : Controller
    {
        // initialise service object 
        IBowlerService _BowlerService;
        ITeamService _TeamService;


        public BowlerController(IBowlerService BowlerService)
        {
            _BowlerService = BowlerService;
        }

        [HttpPost]
        public JsonResult GetAllTeams()
        {
            return Json(_TeamService.GetAll(), JsonRequestBehavior.AllowGet);
        }


        // GET: /Bowler
        public ActionResult Index()
        {
            return View(_BowlerService.GetAll());
        }
/*
        // GET: /Bowler
        public ActionResult Active()
        {
            var bowler = DBNull.
        }
*/

        // GET: /Bowler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Bowler/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Bowler bowler)
        {
            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _BowlerService.Create(bowler);
                return RedirectToAction("Index");
            }
            return View(bowler);
        }

        // GET: /Bowler/Edit
        public ActionResult Edit(long Id)
        {
            Bowler bowler = _BowlerService.GetById(Id);
            if (bowler == null)
            {
                return HttpNotFound();
            }
            return View(bowler);
        }

        // POST: /Bowler/Edit
        [HttpPost]
        public ActionResult Edit(Bowler bowler)
        {
            if (ModelState.IsValid)
            {
                _BowlerService.Update(bowler);
                return RedirectToAction("Index");
            }
            return View(bowler);
        }

        // GET: /Bowler/Delete
        public ActionResult Delete(long Id)
        {
            Bowler bowler = _BowlerService.GetById(Id);
            if (bowler == null)
            {
                return HttpNotFound();
            }
            return View(bowler);
        }

        // POST: /Bowler/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long Id, FormCollection data)
        {
            Bowler bowler = _BowlerService.GetById(Id);
            _BowlerService.Delete(bowler);
            return RedirectToAction("Index");
        }
    }
}