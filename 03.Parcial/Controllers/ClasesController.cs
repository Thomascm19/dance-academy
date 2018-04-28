using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _03.Parcial;

namespace _03.Parcial.Controllers
{
    public class ClasesController : Controller
    {
        private baileEntities db = new baileEntities();

        // GET: Clases
        public ActionResult Index()
        {
            var clase = db.Clase.Include(c => c.Cliente);
            return View(clase.ToList());
        }
        // Ajax
        public String Listaclases()
        {

            var data = db.Clase;

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);

            return json;
        }

        // GET: Clases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clase clase = db.Clase.Find(id);
            if (clase == null)
            {
                return HttpNotFound();
            }
            return View(clase);
        }

        // GET: Clases/Create
        public ActionResult Create()
        {
            ViewBag.Codigo_Cliente = new SelectList(db.Cliente, "Codigo_Cliente", "Nombre");
            return View();
        }

        // POST: Clases/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Clase,Descripcion_Baile,Codigo_Cliente,Nombre_Baile")] Clase clase)
        {
            if (ModelState.IsValid)
            {
                db.Clase.Add(clase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo_Cliente = new SelectList(db.Cliente, "Codigo_Cliente", "Nombre", clase.Codigo_Cliente);
            return View(clase);
        }

        // GET: Clases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clase clase = db.Clase.Find(id);
            if (clase == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo_Cliente = new SelectList(db.Cliente, "Codigo_Cliente", "Nombre", clase.Codigo_Cliente);
            return View(clase);
        }

        // POST: Clases/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Clase,Descripcion_Baile,Codigo_Cliente,Nombre_Baile")] Clase clase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo_Cliente = new SelectList(db.Cliente, "Codigo_Cliente", "Nombre", clase.Codigo_Cliente);
            return View(clase);
        }

        // GET: Clases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clase clase = db.Clase.Find(id);
            if (clase == null)
            {
                return HttpNotFound();
            }
            return View(clase);
        }

        // POST: Clases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clase clase = db.Clase.Find(id);
            db.Clase.Remove(clase);
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
