using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class Orden_pedidoController : Controller
    {
        // GET: Orden_pedido
        public ActionResult ListarOrdenes()
        {
            ViewBag.ordenes = new Orden_pedido().ReadAll();
            return View();
        }

        // GET: Orden_pedido/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Orden_pedido/Create
        public ActionResult CrearOrden()
        {
            EnviarProductos();
            EnviarProveedores();
            return View();
        }

        private void EnviarProveedores()
        {
            ViewBag.proveedores = new Proveedor().ReadAll();
        }

        private void EnviarProductos()
        {
            ViewBag.productos = new Producto().ReadAll();
        }

        // POST: Orden_pedido/Create
        [HttpPost]
        public ActionResult CrearOrden([Bind(Include = "Fecha_pedido, Cantidad, Estado, ProductoId, ProveedorId ")] Orden_pedido orden_pedido)
        {
            try
            {
                // TODO: Add insert logic here
                orden_pedido.Save();
                TempData["mensaje"] = "Guardado con exito";
                return RedirectToAction("ListarOrdenes");

            }
            catch
            {
                return View(orden_pedido);
            }
        }

        // GET: Orden_pedido/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Orden_pedido/Edit/5
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

        // GET: Orden_pedido/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Orden_pedido/Delete/5
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
