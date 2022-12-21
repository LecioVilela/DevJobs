using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.Application.InputModels
{
    public class JobInputModel
    {
        public int Job_Id { get; set; }
        public string Job_Title { get; set; }
        public string Job_Desc { get; set; }
        public string Job_Company { get; set; }
        public string Company_Url { get; set; }
        public bool Remote { get; set; }
        public decimal Job_Salary { get; set; }
        public string Job_Subscribe_Url { get; set; }
        public int Job_Level { get; set; }
    }
}