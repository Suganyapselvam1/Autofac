using AutofacWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacWeb.Implementation
{
    public class Restaurant : IRestaurant
    {
        public IEnumerable<string> GetAll()
        {
            var restaurants = new List<string>();
            restaurants.Add("Scoot's Pizza");
            restaurants.Add("Domino's Pizza");
            return restaurants;
        }
    }
}