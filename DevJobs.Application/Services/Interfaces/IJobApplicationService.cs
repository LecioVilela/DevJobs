using DevJobs.Application.InputModels;
using DevJobs.Application.ViewModels;

namespace DevJobs.Application.Services.Interfaces
{
    public interface IJobApplicationService
    {
        JobApplicationViewModel GetById(int id);
        int Create(NewApplicationInputModel inputModel);
    }
}