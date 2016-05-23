using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.Model;
using League.Service;
using System.Net;
using League.ViewModels;

namespace League.Controllers
{
    public class TeamController : Controller
    {
        // Initialise SERVICE object 
        ITeamService _teamService;

        public TeamController(ITeamService TeamService)
        {
            _teamService = TeamService;
        }

        // GET: /Team
        public ActionResult Index()
        {
            List<TeamViewModel> vmList = new List<TeamViewModel>();

            IEnumerable<Team> teams = _teamService.GetAll();
            foreach (var team in teams)
            {
                TeamViewModel vm = ViewModelMapper.TeamToVM(team);
                vmList.Add(vm);
            }

            return View(vmList);
        }

        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Team team = _teamService.GetById(id.Value);
            if (team == null)
            {
                return HttpNotFound();
            }

            TeamViewModel vm = ViewModelMapper.TeamToVM(team);
            return View(vm);
        }

        // GET: /Team/Create
        public ActionResult Create()
        {
            Team team = new Team { RoundWinner = 0, ActiveFlag = "Y" };

            TeamViewModel vm = ViewModelMapper.TeamToVM(team);
            return View(vm);
        }

        // POST: /Team/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="TeamName,RoundWinner,ActiveFlag")]TeamViewModel teamvm)
        {
            Team team = ViewModelMapper.TeamFromVM(teamvm);
            if (ModelState.IsValid)
            {
                _teamService.Create(team);
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

            Team team = _teamService.GetById(id.Value);
            if (team == null)
            {
                return HttpNotFound();
            }

            TeamViewModel vm = ViewModelMapper.TeamToVM(team);
            return View(vm);
        }

        // POST: /Team/Edit
        [HttpPost]
        public ActionResult Edit([Bind(Include="Id,TeamName,RoundWinner,ActiveFlag")]Team team)
        {
            if (ModelState.IsValid)
            {
                _teamService.Update(team);
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

            Team team = _teamService.GetById(id.Value);
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
            Team team = _teamService.GetById(id);
            _teamService.Delete(team);
            return RedirectToAction("Index");
        }
    }
}