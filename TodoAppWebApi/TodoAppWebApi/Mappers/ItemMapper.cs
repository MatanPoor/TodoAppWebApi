using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;
using TodoAppWebApi.Models.Dtos;

namespace TodoAppWebApi.Mappers
{
    public class ItemMapper
    {
        public static ItemDto Map(Item item)
        {
            ItemDto dto = new ItemDto()
            {
                id = item.id,
                caption = item.caption,
                isCompleted = item.isCompleted,
                listId = item.listId
            };
            return dto;
        }
    }
}
