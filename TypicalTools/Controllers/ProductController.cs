using TypicalTools.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace TypicalTools.Controllers
{
    // Controller class for products
    public class ProductController : Controller
    {
        private readonly ContextModel _mainContextModel;

        // Class constructor that calls context model object 
        public ProductController(ContextModel productContextModel)
        {
            _mainContextModel = productContextModel;
        }

        // Displays all products
        public IActionResult Index()
        {
            var products = _mainContextModel.Products;
            return View(products);
        }
        // Sends Get request to server and returns create product page
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        // Sends Http Post request to server that creates a new product
        [HttpPost]
        public IActionResult CreateProduct(IFormCollection iformcollection)
        { 
            // Collects product details in collection
            var productName = (string)iformcollection["ProductName"];
            var productCode = (string)iformcollection["ProductCode"];
            var productDescription = (string)iformcollection["ProductDescription"];
            var productPrice = (string)iformcollection["ProductPrice"];

            // Sets the product details to be added to new product
            Product product = new Product()
            {
                ProductName = productName,
                ProductDescription = productDescription,
                ProductPrice = decimal.Parse(productPrice),

            };
            // Adds new product, saves product to database and redirects user to index
            _mainContextModel.Products.Add(product);
            _mainContextModel.SaveChanges();
            return RedirectToAction("Index");
        }

        // Sends a Http Get request to retrieve product data based on id and displays delete product page
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = _mainContextModel.Products.FirstOrDefault(a => a.ProductCode == id);
            return View(product);
        }
        
        // Confirms the deletion of the product
        [HttpPost]
        public IActionResult ConfirmDeleteProduct(int productCode)
        {
            var product = _mainContextModel.Products.FirstOrDefault(a => a.ProductCode == productCode);

            if (product != null)
            {
                // Removes the product from the model 
                _mainContextModel.Products.Remove(product);
            }
            // Deletes and saves to database 
            _mainContextModel.SaveChanges();
            // Displays index page
            return RedirectToAction("Index");
        }

        // Sends a Http GET request to retrieve data to update a product
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _mainContextModel.Products.FirstOrDefault(a => a.ProductCode == id);
            return View(product);
        }

        // Sends a HTTP Post method that Updates product 
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _mainContextModel.Products.Update(product);

            _mainContextModel.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}