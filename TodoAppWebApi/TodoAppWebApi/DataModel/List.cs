using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.DataModel
{
    public class List
    {
        public int id { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string icon { get; set; }

        public List<Item> items { get; set; }

    }
}
