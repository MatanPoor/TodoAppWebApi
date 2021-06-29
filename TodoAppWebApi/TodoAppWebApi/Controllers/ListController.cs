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

        [HttpGet("{id}")]
        public async Task<ActionResult<List>> GetListById(string id)
        {
            var result = await _todosAppRepository.GetListById(int.Parse(id));
            var response = ListMapper.Map(result);
            return Ok(response);
        }

        // POST api/<ListController>
        [HttpPost("")]
        public async Task<ActionResult<List>> AddList(List list)
        {
            var result = await _todosAppRepository.AddList(list);
            return Ok(result);
        }

        // PUT api/<ListController>/5
        [HttpPut("")]
        public async Task<ActionResult<List>> EditList(List list)
        {
            var result = await _todosAppRepository.EditList(list);
            return Ok(result);
        }

        // DELETE api/<ListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _todosAppRepository.DeleteList(id);
        }
    }
}
