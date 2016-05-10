using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALC_P2.Controllers
{
    public class MatrizController : Controller
    {
        // GET: Matriz
        public ActionResult Index()
        {
            return View();
        }

        // GET: Matriz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matriz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matriz/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matriz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matriz/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matriz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matriz/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
