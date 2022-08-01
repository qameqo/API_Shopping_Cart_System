using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_API.Models
{
    public class MainModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string gun { get; set; }
    }
    public class ResponseMainModel
    {
        public string name { get; set; }
    }
    public class ListModel
    {
        public List<FirstListModel> FirstList { get; set; }
        public List<SecondListModel> SecondList { get; set; }
    }

    public class FirstListModel
    {
        public string datenow { get; set; }
        public string nextdate { get; set; }
        public string lastdate { get; set; }
    }
    public class SecondListModel
    {
        public string datenow { get; set; }
        public string nextdate { get; set; }
        public string lastdate { get; set; }
    }
}
