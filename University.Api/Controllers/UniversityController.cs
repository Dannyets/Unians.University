using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unians.University.DAL.Interfaces;
using University.Api.Models;
using University.DAL.Models;

namespace University.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly IUniversityRepository _repository;

        public UniversityController(IUniversityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UniversityApiModel>>> Get()
        {
            var universities =  await _repository.GetAll();

            return Ok(universities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UniversityApiModel>> Get(int id)
        {
            var university = await _repository.GetById(id);

            return Ok(university);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UniversityApiModel value)
        {
            var dbEntity = new UniversityDbModel();

            await _repository.Add(dbEntity);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UniversityApiModel value)
        {
            var dbEntity = new UniversityDbModel();

            await _repository.Update(dbEntity);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);

            return Ok();
        }
    }
}
