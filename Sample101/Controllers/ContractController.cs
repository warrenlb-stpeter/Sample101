using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample101.Models;

namespace Sample101.Controllers
{
    public class ContractController : Controller
    {
        // GET: ContractController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContractController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContractController/Create
        [NoDirectAccess]
        public ActionResult Create()
        {
            ContractViewModel _contract = new ContractViewModel();
            //Load or populate
            return View(_contract);
        }

        // POST: ContractController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContractViewModel _contract)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(_contract);
                }

                //serviceUnit

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContractController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContractController/Edit/5
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

        // GET: ContractController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContractController/Delete/5
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
