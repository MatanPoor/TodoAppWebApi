using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppWebApi.Entities;

namespace TodoAppWebApi.Services
{
    public interface IDataService
    {
        Task AddItemToFile(jsonItem item);
        Task AddListToFile(jsonLists list);
        Task<IEnumerable<jsonItem>> GetAllItems();
        Task<IEnumerable<jsonLists>> GetAllLists();
    }
}