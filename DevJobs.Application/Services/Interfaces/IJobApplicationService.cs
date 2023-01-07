using DevJobs.Application.InputModels;
using DevJobs.Application.ViewModels;

namespace DevJobs.Application.Services.Interfaces
{
    public interface IJobApplicationService
    {
        int Create(NewApplicationInputModel inputModel);
        JobApplicationViewModel GetById(int id);
    }
}