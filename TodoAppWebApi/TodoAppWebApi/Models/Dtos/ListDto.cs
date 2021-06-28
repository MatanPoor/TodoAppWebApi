using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.Models.Dtos
{
    public class ListDto
    {
        public int id { get; set; }
        public string caption { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string icon { get; set; }
    }
}
