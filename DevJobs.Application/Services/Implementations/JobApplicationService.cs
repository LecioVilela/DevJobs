using DevJobs.Application.InputModels;
using DevJobs.Application.Services.Interfaces;
using DevJobs.Application.ViewModels;
using DevJobs.Core.Entities;
using DevJobs.Infrastructure.Persistence;

namespace DevJobs.Application.Services.Implementations
{
    public class JobApplicationService : IJobApplicationService
    {
        private readonly DevJobsDbContext _dbContext;

        public JobApplicationService(DevJobsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewApplicationInputModel inputModel)
        {
            var jobApplication = new JobApplication(inputModel.CandidatesName, inputModel.CandidatesEmail, inputModel.CandidatesLinkedin);

            _dbContext.JobApplications.Add(jobApplication);
            _dbContext.SaveChanges();

            return jobApplication.Id;
        }

        public void Delete(int id)
        {
            var job = _dbContext.JobApplications.SingleOrDefault(j => j.Id == id);
            _dbContext.SaveChanges();
        }

        public List<JobApplicationViewModel> GetAll(string query)
        {
            var jobApplication = _dbContext.JobApplications;

            var applicationViewModel = jobApplication
            .Select(j => new JobApplicationViewModel(j.Id, j.CandidatesName, j.CandidatesEmail))
            .ToList();

            return applicationViewModel;
        }

        public JobApplicationViewModel GetById(int id)
        {
            var jobApplication = _dbContext.JobApplications.SingleOrDefault(j => j.Id == id);

            if (jobApplication is null)
            {
                return null;
            }

            var applicationViewModel = new JobApplicationViewModel(jobApplication.Id, jobApplication.CandidatesName, jobApplication.CandidatesEmail);

            return applicationViewModel;
        }
    }
}