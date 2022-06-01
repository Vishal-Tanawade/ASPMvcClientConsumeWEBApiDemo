using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMvcClientConsumeWEBApiDemo.Controllers
{
    public class ComputerProductsController : Controller
    {
        // GET: ComputerProductsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ComputerProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ComputerProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComputerProductsController/Create
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

        // GET: ComputerProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ComputerProductsController/Edit/5
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

        // GET: ComputerProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ComputerProductsController/Delete/5
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
