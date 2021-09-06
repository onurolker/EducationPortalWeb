using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Areas.Admin.Controllers
{
    [Area("Admin"), Route("Admin/[controller]")]
    public class EducatorTypeController : Controller
    {
        // GET: EducatorTypeController
      
        [HttpGet, Route("[action]")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: EducatorTypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EducatorTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EducatorTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EducatorTypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EducatorTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EducatorTypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EducatorTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
