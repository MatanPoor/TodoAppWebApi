using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoAppWebApi.DataModel;
using TodoAppWebApi.Mappers;
using TodoAppWebApi.Services.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAppWebApi.Controllers
{
    [Route("lists")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly ITodosAppRepository _todosAppRepository;
        public ListController(ITodosAppRepository todosAppRepository)
        {
            _todosAppRepository = todosAppRepository;
        }

        // GET: api/<ListController>
        [HttpGet]
        public async Task<ActionResult<List<List>>> GetLists()
        {
            var result = await _todosAppRepository.GetLists();
            var response = result.Select(x => ListMapper.Map(x)).ToList();
            return Ok(response);
        }

        // GET api/<ListController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ListController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
