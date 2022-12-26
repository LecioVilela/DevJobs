using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobs.Core.Enum;

namespace DevJobs.Application.InputModels
{
    public class JobInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string CompanyUrl { get; set; }
        public bool Remote { get; set; }
        public decimal Salary { get; set; }
        public string SubscribeUrl { get; set; }
        public JobLevelEnum Level { get; set; }
    }
}