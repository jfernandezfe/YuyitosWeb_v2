using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuyitosWeb.Negocio;
using System.Web.Mvc;

namespace YuyitosWeb.Controllers
{
    public class ProveedorController : Controller
    {
        // GET: Proveedor
        public ActionResult ListarProveedor()
        {
            ViewBag.proveedores = new Proveedor().ReadAll();
            return View();
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proveedor/Create
        public ActionResult CrearProveedor()
        {
            EnviarRubros();
            EnviarComunas();
            EnviarRegiones();
            return View();
        }

        private void EnviarRegiones()
        {
            ViewBag.regiones = new Region().ReadAll();
        }

        private void EnviarComunas()
        {
            ViewBag.comunas = new Comuna().ReadAll();
        }

        private void EnviarRubros()
        {
            ViewBag.rubros = new Rubro().ReadAll();
        }

        // POST: Proveedor/Create
        [HttpPost]
        public ActionResult CrearProveedor([Bind(Include = "Rut_proveedor, Nombre_proveedor, Telefono, Email, Razon_social, Direccion, RubroId, ComunaId, RegionId" )]Proveedor proveedor)
        {
            try
            {
                // TODO: Add insert logic here
                proveedor.Save();
                TempData["mensae"] = "Guardado con exito.";
                return RedirectToAction("ListarProveedor");
            }
            catch
            {
                return View(proveedor);
            }
        }

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proveedor/Edit/5
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

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proveedor/Delete/5
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
