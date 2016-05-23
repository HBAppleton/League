using League.Model;
using League.Service;
using League.ViewModels;
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
            List<VweekViewModel> vmList = new List<VweekViewModel>();

            IEnumerable<Vweek> vweek = _vweekService.GetActive();
            foreach(var week in vweek)
            {
                VweekViewModel vm = ViewModelMapper.VweektoVM(week);
                vmList.Add(vm);
            }

            return View(vmList);
        }
    }
}