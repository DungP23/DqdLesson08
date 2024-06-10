using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DqdLesson8.Models;

namespace DqdLesson8.Controllers
{
    public class DqdBooksController : Controller
    {
        private DqdBookStore db = new DqdBookStore();
        private object dqdBook;

        public object EntityState { get; private set; }

        // GET:DqdBooks
        public ActionResult DqdIndex()
        {
            return View(db.DqdBooks.ToList());
        }

        // GET: DqdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DqdBook dqdBook = db.DqdBooks.Find(id);
            return DqdBook != null ? View(DqdBook) : HttpNotFound();
        }

        // GET: DqdBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DqdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DqdBookId,DqdTitle,DqdAuthor,DqdYear,DqdPublisher,DqdPicture,DqdCategoryId")] DqdBook dqdBook)
        {
            if (ModelState.IsValid)
            {
                _ = db.DqdBook.Add(dqdBook);
                db.SaveChanges();
                return RedirectToAction("DqdIndex");
            }

            return View(dqdBook);
        }

        // GET: DqdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DqdBook dqdBook = db.DqdBooks.Find(id);
            if (dqdBook == null)
            {
                return HttpNotFound();
            }
            return View(dqdBook);
        }

        // POST: dqdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DqdBookId,DqdTitle,DqdAuthor,DqdYear,DqdPublisher,DqdPicture,DqdCategoryId")] DqdBook dqdBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dqdBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DqdIndex");
            }
            return View(dqdBook);
        }

        // GET: DqdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DqdBook dqdBook = db.DqdBooks.Find(id);
            if (dqdBook == null)
            {
                return HttpNotFound();
            }
            return View(dqdBook);
        }

        // POST: DqdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DqdBook dqdBook = db.DqdBooks.Find(id);
            db.DqdBook.Remove(dqdBook);
            db.SaveChanges();
            return RedirectToAction("DqdIndex");
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