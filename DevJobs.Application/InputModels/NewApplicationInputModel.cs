using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Application.InputModels
{
    public class NewApplicationInputModel
    {
        public string CandidatesName { get; set; }
        public string CandidatesEmail { get; set; }
        public string CandidatesLinkedin { get; set; }
    }
}