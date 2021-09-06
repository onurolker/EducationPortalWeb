using EducationPortal.Data.Repository;
using EducationPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationPortal.Areas.Admin.Controllers
{
    [Area("Admin"), Route("Admin/[controller]")]
    public class EducationController : Controller
    {
        EducationRepository educationRepository;
        EducationCategoriesRepository educationCategoriesRepository;
        public EducationController()
        {
            educationRepository = new EducationRepository();
            educationCategoriesRepository = new EducationCategoriesRepository();
        }
        // GET: EducationController

        [HttpGet, Route("[action]")]
        public ActionResult Index()
        {
            var list = educationRepository.TList();
            return View(list);
        }

        // GET: EducationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        SelectList list;
        // GET: EducationController/Create
        [Route("[action]/{page:int?}")]
        public ActionResult Create()
        {
            list = new SelectList(educationCategoriesRepository.TList(), "Id", "CategoryName");
            ViewBag.CategoryViewBag = list;
            return View();
        }

        // POST: EducationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("[action]/{page:int?}")]
        public ActionResult Create(IFormCollection collection, EducationViewModel educationViewModel)
        {
            list = new SelectList(educationCategoriesRepository.TList(), "Id", "CategoryName");
            ViewBag.CategoryViewBag = list;
            var val = Request.Form["EducationCategoriesViewModelId"];
            bool convertValBoolean = Int32.TryParse(val, out int convertVal);
            
            educationViewModel.EducationCategoriesViewModelId = convertVal;
            educationRepository.TAdd(educationViewModel);
            return RedirectToAction("Index", "Education");


            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet, Route("[action]")]
        // GET: EducationController/Edit/5
        public ActionResult Edit(int id)
        {
            var details = educationRepository.TList("EducationCategoriesViewModel");
            return View("Edit",details);
        }

        // POST: EducationController/Edit/5
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

        // GET: EducationController/Delete/5
        [HttpGet, Route("[action]/{page:int?}")]
        [Obsolete]
        public ActionResult Delete(EducationViewModel educationViewModel)
        {
            educationRepository.TDelete(educationViewModel);
            return RedirectToAction(nameof(Index));
        }

        // POST: EducationController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
