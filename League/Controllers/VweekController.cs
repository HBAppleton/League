using League.Model;
using League.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace League.Controllers
{
    public class VweekController : Controller
    {
        // Initialise SERVICE object 
        IVWeekService _vweekService;

        public VweekController(IVWeekService vweekService)
        {
            _vweekService = vweekService;
        }

        // GET: /Week
        public ActionResult Index()
        {
            return View(_vweekService.GetAll());
        }

        // GET: /Week
        public ActionResult Active()
        {
            return View(_vweekService.GetActive());
        }

    }
}