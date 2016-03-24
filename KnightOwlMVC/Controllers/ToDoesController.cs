using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KnightOwlMVC.Models;
using KnightOwlMVC.Models.StaffModels;

namespace KnightOwlMVC.Controllers
{
    public class ToDoesController : Controller
    {
        private KnightOwlContext db = new KnightOwlContext();

        public ActionResult _ToDo()
        {
            return View(db.ToDoes.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Complete([Bind(Include = "ToDoId,Complete")] ToDo @todo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@todo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Home");
        }

        // GET: ToDoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ToDoId,Priority,Text,Date,Complete")] ToDo toDo)
        {
            if (ModelState.IsValid)
            {
                db.ToDoes.Add(toDo);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            return View(toDo);
        }

    }
}
