﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TIYGiftExchange.Models;
using TIYGiftExchange.ViewModels;

namespace TIYGiftExchange.Controllers
{
    public class GiftController : Controller
    {
        // GET: Gift
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gift/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gift/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gift/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Gift/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gift/Edit/5
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

        // GET: Gift/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gift/Delete/5
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
