using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;
using TodoAppWebApi.Models.Dtos;

namespace TodoAppWebApi.Mappers
{
    public class ListMapper
    {
        public static ListDto Map(List list)
        {
            ListDto dto = new ListDto()
            {
                id = list.id,
                caption = list.caption,
                description = list.description,
                color = list.color,
                icon = list.icon
            };
            return dto;
        }
    }
}
