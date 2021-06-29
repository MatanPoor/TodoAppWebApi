using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;
using TodoAppWebApi.Entities;
using TodoAppWebApi.Mappers;
using TodoAppWebApi.Services.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAppWebApi.Controllers
{
    [Route("items")]
    [ApiController]
    public class ItemsControler : ControllerBase
    {
        private readonly ITodosAppRepository _todosAppRepository;
        public ItemsControler(ITodosAppRepository todosAppRepository)
        {
            _todosAppRepository = todosAppRepository;
        }

        // GET: api/<ItemsControler>
        [HttpGet("{listid}")]
        public async Task<ActionResult<List<Item>>> GetItemsById(string listid)
        {
            var result = await _todosAppRepository.GetItemsById(int.Parse(listid));
            var response = result.Select(x => ItemMapper.Map(x)).ToList();
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetActiveItems()
        {
            var result = await _todosAppRepository.GetActiveItems();
            var response = result.Select(x => ItemMapper.Map(x)).ToList();
            return Ok(response);
        }


        // POST api/<ItemsControler>
        [HttpPost("")]
        public async Task<ActionResult<Item>> AddItem(Item item)
        {
            var result = await _todosAppRepository.AddItem(item);
            return Ok(result);
        }

        // PUT api/<ItemsControler>/5
        [HttpPut("")]
        public async Task<ActionResult<Item>> EditItem(Item item)
        {
            var result = await _todosAppRepository.EditItem(item);
            return Ok(result);
        }

        // DELETE api/<ItemsControler>/5
        [HttpDelete("{id}")]
        public void DeleteItems(int id)
        {
            _todosAppRepository.DeleteItems(id);
        }
    }
}
