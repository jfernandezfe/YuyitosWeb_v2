﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class RecepcionController : Controller
    {
        // GET: Recepcion
        public ActionResult ListarRecepcion()
        {
            ViewBag.recepciones = new Recepcion().ReadAll();
            return View();
        }

        // GET: Recepcion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recepcion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recepcion/Create
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

        // GET: Recepcion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recepcion/Edit/5
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

        // GET: Recepcion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recepcion/Delete/5
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
