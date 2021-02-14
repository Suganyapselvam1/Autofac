using AutofacWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacWeb.Implementation
{
    public class Vechile : IVechile
    {
        public int GetMileage()
        {
            return 5;
        }
    }
}