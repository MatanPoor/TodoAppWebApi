using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.Entities;

namespace TodoAppWebApi.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly List<jsonLists> _lists;
        private readonly List<jsonItem> _items;
        private IDataService _data;

        public RepositoryService(IDataService data)
        {
            _lists = new();
            _items = new();
            _data = data;
        }
        public Task<jsonItem> AddNewItem(jsonItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonLists> AddNewList(jsonLists list)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonItem> DeleteItem(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonLists> DeleteList(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonItem> EditItem(jsonItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonLists> EditList(jsonLists list)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<jsonItem>> GetAllItems()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<jsonLists>> GetAllLists()
        {
            var t = await _data.GetAllLists();
            return t.ToList();

        }

        public Task<jsonItem> GetItemById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<jsonLists> GetListById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
