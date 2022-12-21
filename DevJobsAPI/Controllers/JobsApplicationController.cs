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
    public class JobsApplicationController : ControllerBase
    {
        /// <summary>
        /// Save a new job
        ///</summary>
        [HttpPost("ReceiveApplication")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] JobApplicationInputModel jobApplicationInputModel)
        {
            return Ok(jobApplicationInputModel);
        }
    }
}