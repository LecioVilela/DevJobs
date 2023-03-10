using DevJobs.Application.InputModels;
using DevJobs.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevJobsAPI.Controllers
{
    [ApiController]
    [Route("api/jobs/{id}/applications")]
    public class JobsApplicationController : ControllerBase
    {
        private readonly IJobApplicationService _applicationService;

        public JobsApplicationController(IJobApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Receive a job application
        ///</summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] NewApplicationInputModel newApplicationInputModel)
        {
            var id = _applicationService.Create(newApplicationInputModel);

            return CreatedAtAction(nameof(GetById), new { id }, newApplicationInputModel);

            // Return 201 as the payload from the response body.
        }

        /// <summary>
        /// Request job application informartion by id.
        ///</summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(int id)
        {
            var jobApplication = _applicationService.GetById(id);

            if (jobApplication is null)
            {
                return NotFound();
            }

            return Ok(jobApplication);
        }
    }
}