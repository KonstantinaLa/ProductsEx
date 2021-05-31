using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FirstAskisiOmadiki.Models;
using FirstAskisiOmadiki.Repositories;

namespace FirstAskisiOmadiki.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepos repos;

        public ProductController()
        {
            repos = new ProductRepos();
        }
        public ActionResult Product(string searchTitle , string sortOrder )
        {
            var products = repos.GetAllProducts();

            ViewBag.currentName = searchTitle;
            ViewBag.currentSortOrder = sortOrder;

            //ViewBag.NSP = String.IsNullOrEmpty(sortOrder) ? "titleDesc" : "";
            ViewBag.NSP = sortOrder == "titleAsc" ? "titleDesc" : "titleAsc";
            ViewBag.PSP = sortOrder == "priceAsc" ? "priceDesc" : "priceAsc";





            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                products = products.Where(p => p.Title.ToUpper().Contains(searchTitle.ToUpper())).ToList();
            }



            switch (sortOrder)
            {
                case "titleDesc" : products = products.OrderByDescending(p => p.Title).ToList(); break;
                //prostethike
                case "titleAsc" : products = products.OrderBy(p => p.Title).ToList(); break;

                case "priceAsc" : products = products.OrderBy(p => p.Price).ToList(); break;
                case "priceDesc" : products = products.OrderByDescending(p => p.Price).ToList(); break;

                default: products = products.OrderBy(p => p.Title).ToList(); break;
            }


            return View(products);
        }

        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = repos.FindById(id);

            if (product == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(product);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,Title,IsExpired,DateModified,Price")] Product product)
        {
            if (!ModelState.IsValid) return View(product);
            repos.Create(product);
            return RedirectToAction("Product");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = repos.FindById(id);

            if (product == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Title,IsExpired,DateModified,Price")] Product product)
        {
            if (!ModelState.IsValid) return View(product);
            repos.Edit(product);
            return RedirectToAction("Product");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var product = repos.FindById(id);

            if (product == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int? id)
        {
            var product = repos.FindById(id);

            if (product == null) return new HttpStatusCodeResult(HttpStatusCode.NotFound);


            repos.Delete(product);
            return RedirectToAction("Product");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            repos.Dispose();
        }
    }
}