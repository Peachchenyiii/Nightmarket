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
    public class BoothController : Controller
    {
        private NightmarketContext db = new NightmarketContext();

        // GET: Booth
        public ActionResult Index()
        {
            return View(db.Booths.ToList());
        }

        // GET: Booth/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booth booth = db.Booths.Find(id);
            if (booth == null)
            {
                return HttpNotFound();
            }
            return View(booth);
        }

        // GET: Booth/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Booth/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BoothId,BoothName,BoothLocation,Operator,BoothIntroduction,CommodityId,NightmarketId")] Booth booth)
        {
            if (ModelState.IsValid)
            {
                db.Booths.Add(booth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(booth);
        }

        // GET: Booth/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booth booth = db.Booths.Find(id);
            if (booth == null)
            {
                return HttpNotFound();
            }
            return View(booth);
        }

        // POST: Booth/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BoothId,BoothName,BoothLocation,Operator,BoothIntroduction,CommodityId,NightmarketId")] Booth booth)
        {
            if (ModelState.IsValid)
            {
                db.Entry(booth).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(booth);
        }

        // GET: Booth/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booth booth = db.Booths.Find(id);
            if (booth == null)
            {
                return HttpNotFound();
            }
            return View(booth);
        }

        // POST: Booth/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booth booth = db.Booths.Find(id);
            db.Booths.Remove(booth);
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
        public ActionResult BoothDetail(int id)
        {
            var _booth = db.Booths.FirstOrDefault(x => x.BoothId == id);
            BoothModel _model = new BoothModel();
            if (_booth != null)
            {
                _model.Id = _booth.BoothId;
                _model.Name = _booth.BoothName;
                _model.Location = _booth.BoothLocation;
                _model.Operator = _booth.Operator;
                _model.Introduction = _booth.BoothIntroduction;
                _model.Products = new List<CommodityModel>();
                var _commodities = db.Commoditys.Where(x => x.BoothId == _booth.BoothId).ToList();
                foreach (var _commodity in _commodities)
                {
                    CommodityModel model = new CommodityModel();
                    model.Id = _commodity.CommodityId;
                    model.Name = _commodity.CommodityName;
                    model.Price = _commodity.CommodityPrice;
                    model.Classification = _commodity.CommodityClassification;
                    _model.Products.Add(model);
                }
                //foreach (var _commodity in _booth.Commoditys)
                //{
                //    ProductModel model = new ProductModel();
                //    model.Id = _commodity.CommodityId;
                //    model.Name = _commodity.CommodityName;
                //    _model.Products.Add(model);
                //}

            }

            return View("Details", _model);
        }
    }
}
