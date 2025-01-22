using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Homework1MVC.Entities;
using Homework1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Homework1MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }        
        
        public IActionResult Drink()
        {
            List<Drink> drink = new()
            {
                new Drink
                {
                    Id = 1,
                    Name = "Sirab",
                    Description = "0.5 Litr su",
                    Price = "1.20 AZN"
                },
                new Drink
                {
                    Id = 2,
                    Name = "Atena",
                    Description = "0.33 Litr ayran",
                    Price = "0.60 AZN"
                },
                new Drink
                {
                    Id = 3,
                    Name = "Coca-Cola",
                    Description = "1 Litr qazlı içki",
                    Price = "1.40 AZN"
                }
            };

            return View(drink);
        }        
        
        public IActionResult HotMeal()
        {
            List<HotMeal> hotMeal = new()
            {
                new HotMeal
                {
                    Id = 1,
                    Name = "Steyk",
                    Description = "Orta bişmiş T-Bone steyk",
                    Price = "70.00 AZN"
                },
                new HotMeal
                {
                    Id = 2,
                    Name = "Kabab",
                    Description = "Quzu ətindən hazırlanmış şiş kabab",
                    Price = "25.00 AZN"
                },
                new HotMeal
                {
                    Id = 3,
                    Name = "Şorba",
                    Description = "İsti servis olunan pomidor şorbası",
                    Price = "6.50 AZN"
                }
            };

            return View(hotMeal);
        }        
        
        public IActionResult FastFood()
        {
            List<FastFood> fastFood = new()
            {
                new FastFood
                {
                    Id = 1,
                    Name = "Burger",
                    Description = "Frenç Frayzla servis olunan dadlı burger",
                    Price = "15.00 AZN"
                },
                new FastFood
                {
                    Id = 2,
                    Name = "Dönər",
                    Description = "Hatay souslu toyuq dönər",
                    Price = "5.00 AZN"
                },
                new FastFood
                {
                    Id = 3,
                    Name = "Pizza",
                    Description = "Marqarita üsulu hazırlanmış 6 dilimli pizza",
                    Price = "8.50 AZN"
                }
            };

            return View(fastFood);
        }



    }
}
