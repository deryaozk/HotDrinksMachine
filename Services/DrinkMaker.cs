using HotDrinksMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static HotDrinksMachine.Models.HotDrink;

namespace HotDrinksMachine.Services
{
    public class DrinkMaker
    {
        public string BoilWater()
        {
            return "Boil some water";
        }

        public string AddPowder(DrinkTypes type)
        {
            if (type == DrinkTypes.Tea)
            {
                //the action for steep the water in the tea

                return "Steep the water in the tea";
            }
            else if (type == DrinkTypes.Coffee)
            {
                //the actions to brew the coffee ground
                return  "Brew the coffee ground";
            }
            else if (type == DrinkTypes.Chocolate)
            {
                //the actions for adding drinking chocolate powder to the water

                return "Add drinking chocolate powder to the water";
            }

            return string.Empty;
        }

        public string PourDrink(DrinkTypes type)
        {
            //the actions for pouring the drink

            return "Pour " + type.ToString() + " in the cup";
        }

        public string AddExtras(DrinkTypes type)
        {
            
            if (type == DrinkTypes.Tea)
            {
                //the actions for steep the water in the tea

                return "Add lemon";             
            }
            else if (type == DrinkTypes.Coffee)
            {
                //the actions to brew the coffee ground

                return "Add sugar and milk";
            }

            return string.Empty;
        }
    }
}