using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.DataModel
{
    public class Item
    {
        public int id { get; set; }
        public string caption { get; set; }
        public bool isCompleted { get; set; }
        public int listId { get; set; }

        public List list { get; set; }

    }
}
