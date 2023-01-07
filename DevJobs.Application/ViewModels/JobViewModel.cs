using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Application.ViewModels
{
    public class JobViewModel
    {
        public JobViewModel(int id, string tittle, DateTime createdAt)
        {
            Id = id;
            Tittle = tittle;
            CreatedAt = createdAt;
        }

        public int Id { get; private set; }
        public string Tittle { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}