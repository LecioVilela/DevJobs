using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Application.ViewModels
{
    public class JobViewModel
    {
        public JobViewModel(string tittle, DateTime createdAt)
        {
            Tittle = tittle;
            CreatedAt = createdAt;
        }

        public string Tittle { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}