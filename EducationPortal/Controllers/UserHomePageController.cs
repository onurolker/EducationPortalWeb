using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Controllers
{
    public class UserHomePageController : Controller
    {
        // GET: UserHomePageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserHomePageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserHomePageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserHomePageController/Create
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

        // GET: UserHomePageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserHomePageController/Edit/5
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

        // GET: UserHomePageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserHomePageController/Delete/5
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
