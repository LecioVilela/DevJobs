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
            _dbContext.SaveChanges();

            return job.Id;
        }

        public void Delete(int id)
        {
            var job = _dbContext.Jobs.SingleOrDefault(j => j.Id == id);
            _dbContext.SaveChanges();
        }

        public List<JobViewModel> GetAll(string query)
        {
            var job = _dbContext.Jobs;

            var jobViewModel = job
            .Select(j => new JobViewModel(j.Id, j.Title, j.CreatedAt))
            .ToList();

            return jobViewModel;
        }

        public JobViewModel GetById(int id)
        {
            var job = _dbContext.Jobs.SingleOrDefault(j => j.Id == id);

            if (job is null)
            {
                return null;
            }

            var jobViewModel = new JobViewModel(job.Id, job.Title, job.CreatedAt);

            return jobViewModel;
        }

        public void Update(UpdateJobInputModel inputModel)
        {
            var job = _dbContext.Jobs.SingleOrDefault(j => j.Id == inputModel.Id);

            job.Update(inputModel.Title, inputModel.Description, inputModel.Salary);

            _dbContext.SaveChanges();
        }
    }
}