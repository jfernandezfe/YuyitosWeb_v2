using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas
        public ActionResult ListarVentas()
        {
            ViewBag.ventas = new Registro_ventas().ReadAll();
            return View();
        }

        // GET: Ventas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ventas/Create
        public ActionResult CrearVenta()
        {
            EnviarProductos();
            return View();
        }

        private void EnviarProductos()
        {
            ViewBag.productos = new Producto().ReadAll();
        }

        // POST: Ventas/Create
        [HttpPost]
        public ActionResult CrearVenta([Bind(Include = "Cantidad, Fecha_venta, Cliente_fiado, ProductoId ")]Registro_ventas regitro_ventas)
        {
            try
            {
                // TODO: Add insert logic here
                regitro_ventas.Save();
                TempData["mensaje"] = "Se registró con éxito.";
                return RedirectToAction("ListarVentas");
            }
            catch
            {
                return View(regitro_ventas);
            }
        }

        // GET: Ventas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ventas/Edit/5
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

        // GET: Ventas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ventas/Delete/5
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
