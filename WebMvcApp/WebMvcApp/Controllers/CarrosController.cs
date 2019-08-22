using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebMvcApp.Models;

namespace WebMvcApp.Controllers
{
    public class CarrosController : Controller
    {
        private ContextDB db = new ContextDB();

        // GET: Carros
        public ActionResult Index()
        {
            return View(db.Carros.ToList());
        }

        // GET: Carros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return HttpNotFound();
            }
            return View(carros);
        }

        // GET: Carros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Placa,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Carros carros)
        {
            if (carros.Placa == null)
            {
                return View();
            }

            if (ModelState.IsValid)
            {                
                db.Carros.Add(carros);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carros);
        }

        // GET: Carros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return HttpNotFound();
            }
            return View(carros);
        }

        // POST: Carros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Placa,Ativo,UsuarioCriacao,UsuarioAlteracao,DataCriacao,DataAlteracao")] Carros carros)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carros).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carros);
        }

        // GET: Carros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Carros carros = db.Carros.Find(id);
            if (carros == null)
            {
                return HttpNotFound();
            }
            return View(carros);
        }

        // POST: Carros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Carros carros = db.Carros.Find(id);
            db.Carros.Remove(carros);
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
