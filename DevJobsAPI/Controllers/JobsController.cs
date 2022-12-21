using DevJobs.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevJobsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        /// <summary>
        /// Save a new job
        ///</summary>
        [HttpPost("CreateJob")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] Job job)
        {
            return Ok(job);
        }

        /// <summary>
        /// Edit a job
        /// </summary>
        [HttpPatch("EditJob")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Patch([FromBody] Job job)
        {
            return Ok(job);
        }

        /// <summary>
        /// Delete a job
        /// </summary>
        [HttpDelete("DeleteJob/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}