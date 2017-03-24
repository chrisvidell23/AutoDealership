using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoDealership.Models;

namespace AutoDealership.Models
{
    public class Automobile
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
    }
}