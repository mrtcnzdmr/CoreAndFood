using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        Context context = new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page=1)
        {
            return View(foodRepository.TList("Category").ToPagedList(page,3));
        }
        [HttpGet]
        public IActionResult FoodAdd()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.val = values;
            return View();
        }
        [HttpPost]
        public IActionResult FoodAdd(Food p)
        {
            foodRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult FoodRemove(int id)
        {
            foodRepository.TRemove(new Food { FoodId = id });
            return RedirectToAction("Index");
        }
        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGet(id);
            List<SelectListItem> values = (from y in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = y.CategoryName,
                                               Value = y.CategoryId.ToString()
                                           }).ToList();
            ViewBag.val = values;
            Food f = new Food()
            {
                FoodId = x.FoodId,
                CategoryId = x.CategoryId,
                FoodName = x.FoodName,
                FoodStock = x.FoodStock,
                FoodPrice=x.FoodPrice,
                FoodDescription=x.FoodDescription,
                FoodImageUrl=x.FoodImageUrl
            };
            return View(f);
        }
        [HttpPost]
        public IActionResult FoodUpdate(Food p)
        {
            var x = foodRepository.TGet(p.FoodId);
            x.FoodName = p.FoodName;
            x.FoodStock = p.FoodStock;
            x.FoodPrice = p.FoodPrice;
            x.FoodImageUrl = p.FoodImageUrl;
            x.FoodDescription = p.FoodDescription;
            x.CategoryId = p.CategoryId;
            foodRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

    }
}
