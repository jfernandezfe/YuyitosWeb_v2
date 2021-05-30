using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class Tipo_productoController : Controller
    {
        // GET: Tipo_producto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tipo_producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tipo_producto/Create
        public ActionResult CrearTipoProducto()
        {
            ViewBag.subfamilias = new Subfamilia().ReadAll();
            return View();
        }


        // POST: Tipo_producto/Create
        [HttpPost]
        public ActionResult CrearTipoProducto([Bind(Include = "Nombre_tipo, SubfamiliaId")]Tipo_producto tipo_producto)
        {
            try
            {
                // TODO: Add insert logic here
                tipo_producto.Save();
                TempData["Mensaje"] = "Guardado con éxito";
                return RedirectToAction("CrearTipoProducto");
            }
            catch
            {
                return View(tipo_producto);
            }
        }

        // GET: Tipo_producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tipo_producto/Edit/5
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

        // GET: Tipo_producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipo_producto/Delete/5
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
