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

        public async Task<List<Item>> GetItems(int id)
        {
            var items = await _toDoAppDataContext.Items
                .Select(x=>x)
                .Where(x=>x.listId==id)
                .ToListAsync();
            return items;
        }

        public async Task<List<Item>> GetActiveItems()
        {
            var items = await _toDoAppDataContext.Items
                .Select(x => x)
                .Where(x => !x.isCompleted)
                .ToListAsync();
            return items;
        }
    }
}
