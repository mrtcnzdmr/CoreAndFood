using CoreAndFood.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult VisulalizeProductResult()
        {
            return Json(ProductList());
        }
        public List<Class1> ProductList()
        {
            List<Class1> cs = new List<Class1>();
            cs.Add(new Class1()
            {
                ProductName = "Computer",
                Stock = 150
            });
            cs.Add(new Class1()
            {
                ProductName = "Lcd",
                Stock = 75
            });
            cs.Add(new Class1()
            {
                ProductName = "Usb Disc",
                Stock = 220
            });
            return cs;
        }
        public IActionResult Index3()
        {
            return View();
        }
        public IActionResult VisulalizeProductResult2()
        {
            return Json(FoodList());
        }
        public List<Class2> FoodList()
        {
            List<Class2> cs2 = new List<Class2>();
            using (var context = new Context())
            {
                cs2 = context.Foods.Select(x => new Class2
                {
                    foodname = x.FoodName,
                    stock = x.FoodStock
                }).ToList();
            }
            return cs2;
          
        }

        public IActionResult Statistics()
        {
            Context context = new Context();

            var value1 = context.Foods.Count();
            ViewBag.v1 = value1;

            var value2 = context.Categories.Count();
            ViewBag.v2 = value2;

            var value3 = context.Foods.Where(x => x.CategoryId == 1).Count();
            ViewBag.v3 = value3;

            var value4 = context.Foods.Where(x => x.CategoryId == context.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryId).FirstOrDefault()).Count();
            ViewBag.v4 = value4;

            var value5 = context.Foods.Sum(x => x.FoodStock);
            ViewBag.v5 = value5;

            var value6 = context.Foods.Where(x => x.CategoryId == context.Categories.Where(x => x.CategoryName == "Grain").Select(y => y.CategoryId).FirstOrDefault()).Count();
            ViewBag.v6 = value6;

            var value7 = context.Foods.Average(x => x.FoodPrice).ToString("0.00");
            ViewBag.v7 = value7;

            var value8 = context.Foods.OrderByDescending(x => x.FoodStock).Select(y => y.FoodName).FirstOrDefault();
            ViewBag.v8 = value8;
            return View();
        }
    }
}
