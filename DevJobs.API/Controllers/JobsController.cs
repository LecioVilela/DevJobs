using DevJobs.Application.InputModels;
using DevJobs.Application.Services;
using DevJobs.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevJobsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var jobs = _jobService.GetAll(query);

            return Ok(jobs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            // Usar o service para consultar
            var job = _jobService.GetById(id);

            if (job is null)
                return NotFound();

            return Ok(job);
        }

        /// <summary>
        /// Save a new job
        ///</summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] NewJobInputModel job)
        {
            var id = _jobService.Create(job);

            return CreatedAtAction(nameof(GetById), new { id }, job);
            // Retornar 201 com o payload no corpo da resposta
            // Atribuir ao header de retorno "location" o resultado de um processamento
            // utilizando os parâmetros passados
            // location: localhost:12345/api/Jobs/123 GET
        }

        /// <summary>
        /// Edit a job
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Update([FromBody] UpdateJobInputModel job)
        {
            _jobService.Update(job);

            return NoContent();
        }

        /// <summary>
        /// Delete a job
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            _jobService.Delete(id);
            
            return NoContent();
        }
    }
}