using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hermesmvc.Models;

namespace hermesmvc.Controllers
{
    public class FixedTEsController : Controller
    {
        private Entities db = new Entities();


        // TEST -----------------
        public ActionResult Test()
        {
            //----
            var getcustomerlist = db.Customers.ToList();
            SelectList list_customer = new SelectList(getcustomerlist, "id", "name");
            ViewBag.CustomerListName = list_customer;

            var getsegmentlist = db.Segments.ToList();
            SelectList list_segment = new SelectList(getsegmentlist, "id", "name");
            ViewBag.SegmentListName = list_segment;

            //----------
            //FormCollection form2 = new FormCollection();
            //if (Request.Form["CustomerList"] != null)
            //{
            //    string temp_var = Request.Form["CustomerList"].ToString();
            //}
           
            //temp_var  = form2["CustomerList"].ToString();
            //----------
            //if (id == null)
            //{
            //    id = 1;
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            var fixedTEs = db.FixedTEs.Include(f => f.Customer).Include(f => f.Segment).Include(f => f.FixedTE_details);
            //----------
            //var fixedTEs = db.FixedTEs.Include(f => f.Customer).Include(f => f.Segment).Include(f => f.FixedTE_details).Where(f => f.customer_id.Equals(1));
            return View(fixedTEs.ToList());
        }

        /* */
        [HttpPost]
        public ActionResult Test(FixedTE FTE, FormCollection form)
        {
            var getcustomerlist = db.Customers.ToList();
            SelectList list_customer = new SelectList(getcustomerlist, "id", "name");
            ViewBag.CustomerListName = list_customer;

            var getsegmentlist = db.Segments.ToList();
            SelectList list_segment = new SelectList(getsegmentlist, "id", "name");
            ViewBag.SegmentListName = list_segment;
            

            var fixedTEs = db.FixedTEs.Include(f => f.Customer).Include(f => f.Segment).Include(f => f.FixedTE_details);

            if (form["CustomerList"] != null && form["SegmentList"] != null)
            {
                int intDDL_Customer = Convert.ToInt32(form["CustomerList"].ToString());
                int intDDL_Segment = Convert.ToInt32(form["SegmentList"].ToString());
                fixedTEs = db.FixedTEs.Include(f => f.Customer).Include(f => f.Segment).Include(f => f.FixedTE_details).Where(f => f.customer_id == intDDL_Customer).Where(f => f.segment_id == intDDL_Segment);
            }

            return View(fixedTEs.ToList());
        }

        // ---------------------

        // GET: FixedTEs
        public ActionResult Index()
        {
            var fixedTEs = db.FixedTEs.Include(f => f.Customer).Include(f => f.Segment).Include(f => f.FixedTE_details);
            return View(fixedTEs.ToList());
        }

        // GET: FixedTEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixedTE fixedTE = db.FixedTEs.Find(id);
            if (fixedTE == null)
            {
                return HttpNotFound();
            }
            return View(fixedTE);
        }

        // GET: FixedTEs/Create
        public ActionResult Create()
        {
            ViewBag.customer_id = new SelectList(db.Customers, "id", "name");
            ViewBag.segment_id = new SelectList(db.Segments, "id", "name");
            ViewBag.fixedte_item_id = new SelectList(db.FixedTE_details, "id", "name");
            return View();
        }

        // POST: FixedTEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,customer_id,year,segment_id,fixedte_item_id,value")] FixedTE fixedTE)
        {
            if (ModelState.IsValid)
            {
                db.FixedTEs.Add(fixedTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.customer_id = new SelectList(db.Customers, "id", "name", fixedTE.customer_id);
            ViewBag.segment_id = new SelectList(db.Segments, "id", "name", fixedTE.segment_id);
            ViewBag.fixedte_item_id = new SelectList(db.FixedTE_details, "id", "name", fixedTE.fixedte_item_id);
            return View(fixedTE);
        }

        // GET: FixedTEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixedTE fixedTE = db.FixedTEs.Find(id);
            if (fixedTE == null)
            {
                return HttpNotFound();
            }
            ViewBag.customer_id = new SelectList(db.Customers, "id", "name", fixedTE.customer_id);
            ViewBag.segment_id = new SelectList(db.Segments, "id", "name", fixedTE.segment_id);
            ViewBag.fixedte_item_id = new SelectList(db.FixedTE_details, "id", "name", fixedTE.fixedte_item_id);
            return View(fixedTE);
        }

        // POST: FixedTEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,customer_id,year,segment_id,fixedte_item_id,value")] FixedTE fixedTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fixedTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.customer_id = new SelectList(db.Customers, "id", "name", fixedTE.customer_id);
            ViewBag.segment_id = new SelectList(db.Segments, "id", "name", fixedTE.segment_id);
            ViewBag.fixedte_item_id = new SelectList(db.FixedTE_details, "id", "name", fixedTE.fixedte_item_id);
            return View(fixedTE);
        }

        // GET: FixedTEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FixedTE fixedTE = db.FixedTEs.Find(id);
            if (fixedTE == null)
            {
                return HttpNotFound();
            }
            return View(fixedTE);
        }

        // POST: FixedTEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FixedTE fixedTE = db.FixedTEs.Find(id);
            db.FixedTEs.Remove(fixedTE);
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
