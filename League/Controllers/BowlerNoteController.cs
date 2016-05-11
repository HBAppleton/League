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
    public class BowlerNoteController : Controller
    {
        IBowlerNoteService _BowlerNoteService;
        IBowlerService     _BowlerService;

        public BowlerNoteController(IBowlerNoteService BowlerNoteService, IBowlerService BowlerService)
        {
            _BowlerNoteService = BowlerNoteService;
            _BowlerService     = BowlerService;
        }
        
        // GET: /BowlerNote
        public ActionResult Index()
        {
            return View(_BowlerNoteService.GetAll());
        }

        // GET: /BowlerNote/Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowlernote bowlernote = _BowlerNoteService.GetById(id.Value);
            if (bowlernote == null)
            {
                return HttpNotFound();
            }

            return View(bowlernote);
        }

        // GET: /BowlerNote/Create
        public ActionResult Create()
        {
            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName");
            return View();
        }

        // POST: /BowlerNote/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BowlerId,Season,Note,Rank")]Bowlernote bowlernote)
        {
            if (ModelState.IsValid)
            {
                _BowlerNoteService.Create(bowlernote);
                return RedirectToAction("Index");
            }

            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", bowlernote.BowlerId);
            return View(bowlernote);
        }

        // GET: /BowlerNote/Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowlernote bowlernote = _BowlerNoteService.GetById(id.Value);
            if (bowlernote == null)
            {
                return HttpNotFound();
            }
            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", bowlernote.BowlerId);
            return View(bowlernote);
        }

        // POST: /Bowlernote/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,BowlerId,Season,Note,Rank")]Bowlernote bowlernote)
        {
            if (ModelState.IsValid)
            {
                _BowlerNoteService.Update(bowlernote);
                return RedirectToAction("Index");
            }

            ViewBag.BowlerId = new SelectList(_BowlerService.GetAll(), "Id", "BowlerName", bowlernote.BowlerId);
            return View(bowlernote);
        }

        // GET: /Bowlernote/Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bowlernote bowlernote = _BowlerNoteService.GetById(id.Value);
            if (bowlernote == null)
            {
                return HttpNotFound();
            }
            return View(bowlernote);
        }

        // POST: /Bowlernote/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Bowlernote bowlernote = _BowlerNoteService.GetById(id);
            _BowlerNoteService.Delete(bowlernote);
            return RedirectToAction("Index");
        }
    }
}