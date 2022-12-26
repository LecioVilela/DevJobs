using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Core.Entities
{
    public class Job : BaseEntity
    {
        public Job(string title, string description, string company, string companyUrl, bool remote, decimal salary, string subscribeUrl, int level)
        {
            Title = title;
            Description = description;
            Company = company;
            CompanyUrl = companyUrl;
            Remote = remote;
            Salary = salary;
            SubscribeUrl = subscribeUrl;
            Level = level;
            CreatedAt = DateTime.Now;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Company { get; private set; }
        public string CompanyUrl { get; private set; }
        public bool Remote { get; private set; }
        public decimal Salary { get; private set; }
        public string SubscribeUrl { get; private set; }
        public int Level { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public void Update(string title, string description, decimal salary)
        {
            Title = title;
            Description = description;
            Salary = salary;
        }
    }
}