using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAppWebApi.Entities;

namespace TodoAppWebApi.Services
{
    public interface IRepositoryService
    {
        Task<jsonItem> AddNewItem(jsonItem item);
        Task<jsonLists> AddNewList(jsonLists list);
        Task<jsonItem> DeleteItem(string id);
        Task<jsonLists> DeleteList(string id);
        Task<jsonItem> EditItem(jsonItem item);
        Task<jsonLists> EditList(jsonLists list);
        Task<List<jsonItem>> GetAllItems();
        Task<List<jsonLists>> GetAllLists();
        Task<jsonItem> GetItemById(string id);
        Task<jsonLists> GetListById(string id);
    }
}