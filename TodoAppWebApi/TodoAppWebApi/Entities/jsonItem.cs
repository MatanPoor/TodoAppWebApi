using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.Entities
{
    public record jsonItem
    (
        int id,
        string caption,
        int listId,
        bool isCompleted
    ){ }


}
