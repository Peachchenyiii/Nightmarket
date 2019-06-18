using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nightmarket.DAL;
using Nightmarket.Models;
using Nightmarket.ViewModels;

namespace Nightmarket.Controllers
{
    public class NightMarketController : Controller
    {
        private NightmarketContext db = new NightmarketContext();

        // GET: NightMarket
        //public ActionResult Index()
        //{
        //return View(db.NightMarkets.ToList());
        //}

        public ActionResult Index(int? id, int? boothID)
        {
            var viewModel = new NightmarketIndexData();
            viewModel.NightMarkets = db.NightMarkets.ToList();

            if (id != null)
            {
                ViewBag.NightmarketId = id.Value;
                viewModel.Booths = db.Booths.Where(x => x.NightmarketId == id).ToList();
            }

            if (boothID != null)
            {
                ViewBag.BoothID = boothID.Value;
                var _commodity = db.Commoditys.FirstOrDefault(x => x.BoothId == boothID);

                if (_commodity != null)
                {
                    viewModel.Commoditys = _commodity;
                }
                else
                {
                    viewModel.Commoditys = null;
                }

            }

            return View(viewModel);
        }

        // GET: NightMarket/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NightMarket nightMarket = db.NightMarkets.Find(id);
            if (nightMarket == null)
            {
                return HttpNotFound();
            }
            return View(nightMarket);
        }

        // GET: NightMarket/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NightMarket/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NightmarketId,NightmarketName,NightmarketIntroduction")] NightMarket nightMarket)
        {
            if (ModelState.IsValid)
            {
                db.NightMarkets.Add(nightMarket);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nightMarket);
        }

        // GET: NightMarket/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NightMarket nightMarket = db.NightMarkets.Find(id);
            if (nightMarket == null)
            {
                return HttpNotFound();
            }
            return View(nightMarket);
        }

        // POST: NightMarket/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NightmarketId,NightmarketName,NightmarketIntroduction")] NightMarket nightMarket)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nightMarket).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nightMarket);
        }

        // GET: NightMarket/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NightMarket nightMarket = db.NightMarkets.Find(id);
            if (nightMarket == null)
            {
                return HttpNotFound();
            }
            return View(nightMarket);
        }

        // POST: NightMarket/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NightMarket nightMarket = db.NightMarkets.Find(id);
            db.NightMarkets.Remove(nightMarket);
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
