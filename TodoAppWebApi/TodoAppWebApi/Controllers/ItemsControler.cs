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
        [HttpGet("items/{id}")]
        public async Task<ActionResult<List<Item>>> GetItems(string id)
        {
            var result = await _todosAppRepository.GetItems(int.Parse(id));
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
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItemsControler>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemsControler>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
