using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;

namespace TodoAppWebApi.Services.Repositories
{
    public interface ITodosAppRepository
    {
        Task<List<List>> GetLists();

        Task<List<Item>> GetItems(int id);

        Task<List<Item>> GetActiveItems();


    }
}