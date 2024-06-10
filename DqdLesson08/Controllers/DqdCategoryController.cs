using DqdLesson8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DqdLesson8.Controllers
{
    public class DqdCategoryController : Controller
    {
        private static DqdBookStore _DqdbookStore;
        public DqdCategoryController()
        {
            _DqdbookStore = new DqdBookStore();
        }
        // GET: DqdCategory
        public ActionResult DqdIndex()
        {
            var dqdCategory = _DqdbookStore.DqdCategories.ToList();
            return View(dqdCategory);
        }
        public ActionResult DqdCreate()
        {
            var DqdCategory = new DqdCategory();
            return View();
        }
        [HttpPost]
        public ActionResult DqdCreate(DqdCategory dqdCategory)
        {
            _DqdbookStore.DqdCategories.Add(dqdCategory);
            _DqdbookStore.SaveChanges();
            return RedirectToAction("DqdIndex");
        }
    }
}