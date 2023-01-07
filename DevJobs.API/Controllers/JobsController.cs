using DevJobs.Application.InputModels;
using DevJobs.Application.Services;
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

        /// <summary>
        /// Request all jobs informations.
        ///</summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(string query)
        {
            var jobs = _jobService.GetAll(query);

            return Ok(jobs);
        }

        /// <summary>
        /// Request job informartion by id.
        ///</summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int id)
        {
            var job = _jobService.GetById(id);

            if (job is null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        /// <summary>
        /// Save a new job.
        ///</summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] NewJobInputModel job)
        {
            var id = _jobService.Create(job);

            return CreatedAtAction(nameof(GetById), new { id }, job);

            // Return 201 as the payload from the response body.
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