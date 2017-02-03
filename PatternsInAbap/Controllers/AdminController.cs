using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PatternsInAbap.Infrastructure;
using PatternsInAbap.Repository;
using PatternsInAbap.Models;

namespace PatternsInAbap.Controllers
{
    public class AdminController : Controller
    {
        IPatternsRepository ptrnRepo = new EFPatternRepository();        
        
        public ActionResult EditPattern(String ptrnName) {
           var ptrn = ptrnRepo.GetPatterns()
                .Where(p => p.Name == ptrnName)
                .FirstOrDefault();

            return ptrn == null ? View("NotFoundPattern", (Object)ptrnName) :
                                  View("EditPattern", ptrn);
        }

        public ActionResult AddPattern() {
            return View("EditPattern", new Pattern());
        }
    }
}