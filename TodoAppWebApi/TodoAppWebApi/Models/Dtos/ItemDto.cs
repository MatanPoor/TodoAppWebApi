using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.Models.Dtos
{
    public class ItemDto
    {
        public int id { get; set; }
        public string caption { get; set; }
        public bool isCompleted { get; set; }
        public int listId { get; set; }
    }
}
