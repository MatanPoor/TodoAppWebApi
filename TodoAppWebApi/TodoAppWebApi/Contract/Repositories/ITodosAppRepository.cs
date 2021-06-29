using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;

namespace TodoAppWebApi.Services.Repositories
{
    public interface ITodosAppRepository
    {
        Task<List<List>> GetLists();

        Task<List<Item>> GetItemsById(int listid);

        Task<List<Item>> GetActiveItems();

        Task<List> GetListById(int id);

        Task<List> AddList(List list);

        Task<Item> AddItem(Item item);
        public void DeleteItems(int id);
        public void DeleteList(int id);

        Task<List> EditList(List list);

        Task<Item> EditItem(Item item);


    }
}