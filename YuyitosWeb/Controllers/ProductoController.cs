using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuyitosWeb.Negocio;

namespace YuyitosWeb.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult ListarProducto()
        {
            ViewBag.productos = new Producto().ReadAll();
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult PCrearTipoProducto()
        {
            EnviarTipos();
            ViewBag.Subfamilias = new Subfamilia().ReadAll();
            return View("CrearTipoProducto");
        }

        private void EnviarTipos()
        {
            ViewBag.tipos = new Tipo_producto().ReadAll();
        }

        // GET: Producto/Create
        public ActionResult CrearProducto()
        {
            EnviarMarcas();
            EnviarTipos();
            EnviarProveedor();
            return View();
        }

        private void EnviarProveedor()
        {
            ViewBag.proveedores = new Proveedor().ReadAll();
        }

        private void EnviarMarcas()
        {
            ViewBag.marcas = new Marca().ReadAll();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult CrearProducto([Bind(Include = "Nombre_producto, Descripcion, Precio_compra, Precio_venta, Fecha_elab, Fecha_venc, Stock, Stock_critico, MarcaId, TipoId, ProveedorId")] Producto producto)
        {
            try
            {
                // TODO: Add insert logic here
                producto.Save();
                TempData["mensaje"] = "Exito al guardar";
                return RedirectToAction("ListarProducto");
            }
            catch
            {
                return View(producto);
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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
