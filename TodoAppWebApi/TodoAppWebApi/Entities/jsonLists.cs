using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppWebApi.Entities
{
    public record jsonLists(
        int id,
        string caption,
        string description,
        string color,
        string icon
    ){ }
}
