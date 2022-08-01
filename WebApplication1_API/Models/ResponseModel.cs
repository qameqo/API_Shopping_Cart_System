using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_API.Models
{
    public class ResponseModel
    {
        public bool success { get; set; }
        public int status { get; set; }
        public Object data { get; set; }
        public string message { get; set; }
        public string errorCode { get; set; }
        public string error { get; set; }
    }
}
