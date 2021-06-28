using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.Entities;

namespace TodoAppWebApi.Services
{
    public class DataService : IDataService
    {
        private const string _basePath = "Data";
        private const string _listsFile = "lists.json";
        private const string _itemsFile = "items.json";

        public async Task<IEnumerable<jsonLists>> GetAllLists()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _basePath, _listsFile);
            var jsonString = await File.ReadAllTextAsync(path);
            var jsonAsObject = JsonConvert.DeserializeObject<IEnumerable<jsonLists>>(jsonString);
            return jsonAsObject;
        }

        public async Task<IEnumerable<jsonItem>> GetAllItems()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _basePath, _itemsFile);
            var jsonString = await File.ReadAllTextAsync(path);
            var jsonAsObject = JsonConvert.DeserializeObject<IEnumerable<jsonItem>>(jsonString);
            return jsonAsObject;
        }

        public Task AddListToFile(jsonLists list)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _basePath, _listsFile);
            var objectToJson = JsonConvert.SerializeObject(list);
            var objectToFile = File.AppendAllTextAsync(path, objectToJson);

            return objectToFile;
        }

        public Task AddItemToFile(jsonItem item)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), _basePath, _itemsFile);
            var objectToJson = JsonConvert.SerializeObject(item);
            var objectToFile = File.AppendAllTextAsync(path, objectToJson);

            return objectToFile;
        }
    }
}
