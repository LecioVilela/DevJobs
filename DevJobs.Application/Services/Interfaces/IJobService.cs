using DevJobs.Application.InputModels;
using DevJobs.Application.ViewModels;

namespace DevJobs.Application.Services
{
    public interface IJobService
    {
        List<JobViewModel> GetAll(string query);
        JobViewModel GetById(int id);
        int Create(NewJobInputModel inputModel);
        void Update(UpdateJobInputModel inputModel);
        void Delete(int id);
    }
}