using SinekliBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SinekliBakkal.WebUI.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}