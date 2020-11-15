using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotDrinksMachine.Models
{
    public class HotDrink
    {
        public string Label;

        public List<string> Messages;

        public enum DrinkTypes
        {
            Tea,
            Coffee,
            Chocolate
        }
    }
}