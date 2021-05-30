using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class BoletaController : Controller
    {
        // GET: Boleta
        public ActionResult ListarBoleta()
        {
            ViewBag.boletas = new Boleta().ReadAll();
            return View();
        }

        // GET: Boleta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Boleta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Boleta/Create
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

        // GET: Boleta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Boleta/Edit/5
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

        // GET: Boleta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Boleta/Delete/5
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
