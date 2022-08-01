using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_API.Models
{
    public class Products
    {
        public List<ListProducts> ListProducts { get; set; }
    }
    public class ListProducts
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string detail { get; set; }
        public string size { get; set; }
        public string amount { get; set; }
    }
}
