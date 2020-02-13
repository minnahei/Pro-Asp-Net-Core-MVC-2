using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //////////////// Creating Filtering Extension Methods ///////////////////////////

            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            Product[] productArray =
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            };

            
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            return View("Index", new string[] {
                $"Array Total: {arrayTotal:C2}" });


            //////////////// Apply Extension Methods to an Interface ///////////////////////////

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product { Name = "Kayak", Price = 275M },
            //    new Product { Name = "Lifejacket", Price = 48.95M }
            //};

            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal = productArray.TotalPrices();

            //return View("Index", new string[] {
            //    $"Cart Total: {cartTotal:C2}",
            //    $"Array Total: {arrayTotal:C2}" });
                



            //////////////// Using Extension Method ///////////////////////////

            //Shoppingcart cart = new Shoppingcart { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });


            //////////////// Pattern Matching in Switch Statements ////////////////////

            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;

            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}

            //return View("Index", new string[] { $"Total: {total:C2}" });




            //////////////// Pattern Matching ////////////////////

            //object[] data = { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; 1 < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //return View("Index", new string[] { $"Total: {total:C2}" });




            //////////////// Using an Index Initializer ////////////////////

            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 95M }

            //    { "Kayak", new Product { Name = "Kayak", Price = 275M} },
            //    { "Lifejacket", new Product { Name = "Lifejacket", Price = 95M} }
            //};

            //return View("Index", products.Keys);




            //////////////// Using Object and Collection Initializers ////////////////////


            //return View("Index", new string[] { "Bob", "Joe", "Alice" });

            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[1] = "Joe";
            //names[2] = "Alice";

            //return View("Index", names);


            //List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0; 
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");

            //    results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            //}

            //return View(results);
        }

    }
}
