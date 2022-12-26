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

        /// <summary>
        /// Save a new job
        ///</summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] Job job)
        {
            return Ok(job);
        }

        /// <summary>
        /// Edit a job
        /// </summary>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Patch([FromBody] Job job)
        {
            return NoContent();
        }

        /// <summary>
        /// Delete a job
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}