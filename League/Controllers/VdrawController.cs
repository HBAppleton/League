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
    public class VdrawController : Controller
    {
        // Initialise SERVICE object 
        IVdrawService _vdrawService;

        public VdrawController(IVdrawService vdrawService)
        {
            _vdrawService = vdrawService;
        }

        // GET: Vdraw
        public ActionResult Index()
        {
            return View(_vdrawService.GetAll());
        }

        // GET: Vdraw
        public ActionResult Active()
        {
            List<VdrawViewModel> vmList = new List<VdrawViewModel>();

            IEnumerable<Vdraw> vdraws = _vdrawService.GetActive();
            foreach (var vdraw in vdraws)
            {
                VdrawViewModel vm = ViewModelMapper.VdrawToVM(vdraw);
                vmList.Add(vm);
            }

            return View(vmList);
        }
    }
}