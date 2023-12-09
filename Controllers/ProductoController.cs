using CRUD_PRODUCTOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_PRODUCTOS.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            using (DataProductos prod = new DataProductos())
            {
                return View(prod.Producto.ToList());
            }
            
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            using (DataProductos prod = new DataProductos())
            {
                return View(prod.Producto.Where(idPr =>idPr.ProductoID ==id));
            }
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Producto productos)
        {
            try
            {
                using (DataProductos prod = new DataProductos())
                {
                    prod.Producto.Add(productos);
                    prod.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            using (DataProductos prod = new DataProductos())
            {
                return View(prod.Producto.Where(idPr => idPr.ProductoID == id).FirstOrDefault());
            }
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Producto productos)
        {
            try
            {
                using (DataProductos prod = new DataProductos()) 
                {
                    prod.Entry(productos).State = System.Data.EntityState.Modified;
                    prod.SaveChanges();
                }

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
            using(DataProductos prod = new DataProductos())
            {
                return View(prod.Producto.Where(idPr => idPr.ProductoID == id).FirstOrDefault());
            }
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DataProductos prod =  new DataProductos()) 
                {
                    Producto productos= prod.Producto.Where(idPr => idPr.ProductoID == id).FirstOrDefault();
                    prod.Producto.Remove(productos);
                    prod.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
