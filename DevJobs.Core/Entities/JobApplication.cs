using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Core.Entities
{
    public class JobApplication : BaseEntity
    {
        public JobApplication(string candidatesName, string candidatesEmail, string candidatesLinkedin)
        {
            CandidatesName = candidatesName;
            CandidatesEmail = candidatesEmail;
            CandidatesLinkedin = candidatesLinkedin;
            SendedAt = DateTime.Now;
        }

        public string CandidatesName { get; private set; }
        public string CandidatesEmail { get; private set; }
        public string CandidatesLinkedin { get; private set; }
        public DateTime SendedAt { get; private set; }
    }
}