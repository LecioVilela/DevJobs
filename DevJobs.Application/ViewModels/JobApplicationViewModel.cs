using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Application.ViewModels
{
    public class JobApplicationViewModel
    {
        public JobApplicationViewModel(int id, string candidatesName, string candidatesEmail)
        {
            Id = id;
            CandidatesName = candidatesName;
            CandidatesEmail = candidatesEmail;
        }

        public int Id { get; private set; }
        public string CandidatesName { get; private set; }
        public string CandidatesEmail { get; private set; }
    }
}