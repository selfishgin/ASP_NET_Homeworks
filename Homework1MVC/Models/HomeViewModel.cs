using Homework1MVC.Entities;
using System.Collections.Generic;

namespace Homework1MVC.Models
{
    public class HomeViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }
    }
}
