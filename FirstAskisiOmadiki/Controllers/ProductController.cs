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
        public ActionResult Product()
        {
            var products = repos.GetAllProducts();

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
        public ActionResult Delete([Bind(Include = "ProductId,Title,IsExpired,DateModified,Price")] Product product)
        {
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