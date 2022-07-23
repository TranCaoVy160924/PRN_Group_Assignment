using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static eStore.Models.DBHelper;
using Ass3.Library;

namespace eStore.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository ProductRepository = null;

        // GET: ProductsController
        public ActionResult Index(string productName = "",
            int lowerPrice = 0, int upperPrice = 0)
        {
            ProductRepository = new ProductRepository();
            IEnumerable<Product> productList = null;

            if (string.IsNullOrEmpty(productName) && lowerPrice == 0 
                && upperPrice == 0)
            {
                productList = ProductRepository.GetProductList();
            }
            else
            {
                productList = ProductRepository
                    .SearchProducts(productName, lowerPrice, upperPrice);
                ViewBag.productName = productName;
                ViewBag.lowerPrice = lowerPrice;
                ViewBag.upperPrice = upperPrice;
            }
            
            return View(productList);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            ProductRepository = new ProductRepository();
            var product = ProductRepository.GetProductByID(id);
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                ProductRepository = new ProductRepository();
                if (ModelState.IsValid)
                {
                    if(product.Category <= 0) { TempData["ErrorMessageCat"] = "Category must > 0"; }
                    if(product.UnitPrice <= 0) { TempData["ErrorMessagepPrice"] = "Price must > 0"; }
                    if(product.UnitsInStock <= 0) { TempData["ErrorMessageStock"] = "Units must > 0"; }
                    if(product.Category <= 0 || product.UnitPrice <= 0 || product.UnitsInStock <= 0)
                    {
                        return RedirectToAction(nameof(Create));
                    }

                    ProductRepository.AddProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            ProductRepository = new ProductRepository();
            var product = ProductRepository.GetProductByID(id);
            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            ProductRepository = new ProductRepository();
            try
            {
                if (ModelState.IsValid)
                {
                    if (product.Category <= 0) { TempData["ErrorMessageCat"] = "Category must > 0"; }
                    if (product.UnitPrice <= 0) { TempData["ErrorMessagepPrice"] = "Price must > 0"; }
                    if (product.UnitsInStock <= 0) { TempData["ErrorMessageStock"] = "Units must > 0"; }
                    if (product.Category <= 0 || product.UnitPrice <= 0 || product.UnitsInStock <= 0)
                    {
                        return RedirectToAction(nameof(Edit));
                    }

                    ProductRepository.UpdateProduct(product);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(product);
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            ProductRepository = new ProductRepository();
            var product = ProductRepository.GetProductByID(id);
            return View(product);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            ProductRepository = new ProductRepository();
            try
            {
                ProductRepository.DeleteProduct(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
