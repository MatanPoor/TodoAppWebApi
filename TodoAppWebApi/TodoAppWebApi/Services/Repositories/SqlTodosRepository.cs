using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataAccess;
using TodoAppWebApi.DataModel;

namespace TodoAppWebApi.Services.Repositories
{
    public class SqlTodosRepository : ITodosAppRepository
    {
        private readonly ToDoAppDataContext _toDoAppDataContext;

        public SqlTodosRepository(ToDoAppDataContext toDoAppDataContext)
        {
            _toDoAppDataContext = toDoAppDataContext;
        }
        public async Task<List<List>> GetLists()
        {
            var items = await _toDoAppDataContext.Lists.ToListAsync();
            return items;
        }

        public async Task<List<Item>> GetItemsById(int listid)
        {
            var items = await _toDoAppDataContext.Items
                .Select(x => x)
                .Where(x => x.listId == listid)
                .ToListAsync();
            return items;
        }

        public async Task<List> GetListById(int id)
        {
            var lists = await _toDoAppDataContext.Lists
                .Select(x => x)
                .Where(x => x.id == id)
                .ToListAsync();
            return lists[0];
        }

        public async Task<List<Item>> GetActiveItems()
        {
            var items = await _toDoAppDataContext.Items
                .Select(x => x)
                .Where(x => !x.isCompleted)
                .ToListAsync();
            return items;
        }

        public async Task<List> AddList(List list)
        {
            _toDoAppDataContext.Lists.Add(list);
            await _toDoAppDataContext.SaveChangesAsync();
            return list;
        }

        public async Task<List> EditList(List list)
        {
            _toDoAppDataContext.Lists.Update(list);
            await _toDoAppDataContext.SaveChangesAsync();
            return list;
        }

        public async Task<Item> EditItem(Item item)
        {
            _toDoAppDataContext.Items.Update(item);
            await _toDoAppDataContext.SaveChangesAsync();
            return item;
        }
        
        public async Task<Item> AddItem(Item item)
        {
            _toDoAppDataContext.Items.Add(item);
            await _toDoAppDataContext.SaveChangesAsync();
            return item;
        }

        public void DeleteItems(int id)
        {
            var items = _toDoAppDataContext.Items
            .Select(x => x)
            .Where(x => x.listId == id);

            foreach (var item in items)
            {
                _toDoAppDataContext.Items.Remove(item);
            }
            _toDoAppDataContext.SaveChangesAsync();
        }

        public void DeleteList(int id)
        {
            var lists = _toDoAppDataContext.Lists
            .Select(x => x)
            .Where(x => x.id == id);
            foreach (var list in lists)
            {
                _toDoAppDataContext.Lists.Remove(list);
            }
            _toDoAppDataContext.SaveChangesAsync();
        }

    }
}
