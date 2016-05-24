using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using League.ViewModels;
using League.Helper;
using League.Service;

namespace League.Controllers
{
    public class SeasonSetupController : Controller
    {
        // Initialise SERVICE object 
        IWeekService _weekService;

        public SeasonSetupController(IWeekService weekService)
        {
            _weekService = weekService;
        }

        // GET: SeasonSetup
        public ActionResult Index()
        {
            return View();
        }

        // GET: SeasonSetup/Create
        public ActionResult Create()
        {
            int li_season = DateTime.Now.Year;

            DateTime ldt_FirstNight = DateHelper.GetLeagueFirstNight(li_season);
            DateTime ldt_Fieldays   = DateHelper.GetFieldaysStartDate(li_season);

            SeasonSetupViewModel seasondates = new SeasonSetupViewModel { Season = li_season,
                                                                          FirstNight = ldt_FirstNight,
                                                                          Fieldays = ldt_Fieldays,
                                                                          Id = 1 };

            return View(seasondates);
        }

        // POST: SeasonSetup/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SeasonSetupViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _weekService.SetupSeason(vm.Season);
                return RedirectToAction("Active", "Vweek");
            }
            return View(vm);
        }
    }
}