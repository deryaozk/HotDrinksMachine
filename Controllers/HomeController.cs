using HotDrinksMachine.Models;
using HotDrinksMachine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static HotDrinksMachine.Models.HotDrink;

namespace HotDrinksMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var types = new DrinkTypes();
            return View(types);
        }

        public ActionResult Select(DrinkTypes type)
        {
            var drink = new DrinkMaker();

            var messages = new List<string>();
            messages.Add(drink.BoilWater());
            messages.Add(drink.AddPowder(type));
            messages.Add(drink.PourDrink(type));
            messages.Add(drink.AddExtras(type));

            var hotDrink = new HotDrink();
            hotDrink.Label = type.ToString();
            hotDrink.Messages = messages;

            return View(hotDrink);
        }
    }
}