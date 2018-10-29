using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using semana_10_01;
using semana_10_01.Models;

namespace semana_10_01.Controllers
{
    public class DetallesController : Controller
    {
        private EleganciaContext db = new EleganciaContext();

        // GET: Detalles
        public ActionResult Index()
        {
            var detalles = db.Detalles.Include(d => d.Pedido).Include(d => d.Producto);
            return View(detalles.ToList());
        }

        // GET: Detalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle detalle = db.Detalles.Find(id);
            if (detalle == null)
            {
                return HttpNotFound();
            }
            return View(detalle);
        }

        // GET: Detalles/Create
        public ActionResult Create()
        {
            ViewBag.IdPedido = new SelectList(db.Pedidoes, "IdPedido", "IdPedido");
            ViewBag.IdProducto = new SelectList(db.Productoes, "IdProducto", "NombreProducto");
            return View();
        }

        // POST: Detalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdDetalle,IdPedido,IdProducto,PrecioUnidad,Cantidad")] Detalle detalle)
        {
            if (ModelState.IsValid)
            {
                db.Detalles.Add(detalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPedido = new SelectList(db.Pedidoes, "IdPedido", "IdPedido", detalle.IdPedido);
            ViewBag.IdProducto = new SelectList(db.Productoes, "IdProducto", "NombreProducto", detalle.IdProducto);
            return View(detalle);
        }

        // GET: Detalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle detalle = db.Detalles.Find(id);
            if (detalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPedido = new SelectList(db.Pedidoes, "IdPedido", "IdPedido", detalle.IdPedido);
            ViewBag.IdProducto = new SelectList(db.Productoes, "IdProducto", "NombreProducto", detalle.IdProducto);
            return View(detalle);
        }

        // POST: Detalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdDetalle,IdPedido,IdProducto,PrecioUnidad,Cantidad")] Detalle detalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPedido = new SelectList(db.Pedidoes, "IdPedido", "IdPedido", detalle.IdPedido);
            ViewBag.IdProducto = new SelectList(db.Productoes, "IdProducto", "NombreProducto", detalle.IdProducto);
            return View(detalle);
        }

        // GET: Detalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Detalle detalle = db.Detalles.Find(id);
            if (detalle == null)
            {
                return HttpNotFound();
            }
            return View(detalle);
        }

        // POST: Detalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Detalle detalle = db.Detalles.Find(id);
            db.Detalles.Remove(detalle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
