using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatternsInAbap.Infrastructure;
using PatternsInAbap.Repository;

namespace PatternsInAbap.Controllers
{
    public class HomeController : Controller
    {
        IPatternsRepository patrnRepo = new EFPatternRepository();

        /*public HomeController(IPatternsRepository ptrnRepo) {
            this.patrnRepo = ptrnRepo;
        }*/
        
        public ActionResult List(String ptrnType)
        {
            return View(ptrnType == null ? patrnRepo.GetPatterns() 
                        : patrnRepo.GetPatterns().Where(p => p.Type == ptrnType));
        }

        public PartialViewResult GetPatternTypes() {
            return PartialView("_GetPatternTypes", PatternInfo.PatternTypes);
        }
    }
}