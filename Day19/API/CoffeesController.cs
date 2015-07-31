using Day19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day19.API
{
    public class CoffeesController : ApiController
    {
        [HttpGet]
        public IList<string> Find(string term)
        {
            var coffees = new List<Coffee>
            {
                new Coffee {Id=1, Type="Latte"},
                new Coffee {Id=2, Type="Large Mocha"},
                new Coffee {Id=3, Type="Lemon Tea"},
                new Coffee {Id=4, Type="Lemon Super Tea"}
            };

            var matches = coffees.Where(c => c.Type.StartsWith(term, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(c => c.Type)
                .Select(c => c.Type)
                .ToList();

            return matches;
        }


        [HttpPost]
        public Boolean SaveOrder(int[] order)
        {
            return true;
        }


    }
}
