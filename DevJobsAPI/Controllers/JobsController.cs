using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobs.Application.InputModels;
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
        public async Task<IActionResult> Post([FromBody] JobInputModel jobInputModel)
        {
            return Ok(jobInputModel);
        }

        /// <summary>
        /// Edit a job
        /// </summary>
        [HttpPatch("EditJob")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Patch([FromBody] JobInputModel jobInputModel)
        {
            return Ok(jobInputModel);
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