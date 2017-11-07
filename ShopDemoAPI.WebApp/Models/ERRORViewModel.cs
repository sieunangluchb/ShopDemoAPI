using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDemoAPI.WebApp.Models
{
    public class ERRORViewModel
    {
        public int ID_ERROR { get; set; }

        public string MESSAGE { get; set; }

        public string STACKTRACE { get; set; }

        public DateTime CREATEDDATE { get; set; }
    }
}