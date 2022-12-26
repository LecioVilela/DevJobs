using DevJobs.Application.InputModels;
using DevJobs.Application.ViewModels;
using DevJobs.Core.Entities;
using DevJobs.Infrastructure.Persistence;

namespace DevJobs.Application.Services.Implementations
{
    public class JobService : IJobService
    {
        private readonly DevJobsDbContext _dbContext;
        public JobService(DevJobsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewJobInputModel inputModel)
        {
            var job = new Job(inputModel.Title, inputModel.Description, inputModel.Company, inputModel.CompanyUrl, inputModel.Remote, inputModel.Salary, inputModel.SubscribeUrl, inputModel.Level);

            _dbContext.Jobs.Add(job);

            return job.Id;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<JobViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public JobViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UpdateJobInputModel inputModel)
        {
            throw new NotImplementedException();
        }
    }
}