using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TargetSalary { get; set; }
        public DateTime? StartDate { get; set; }
        //Candidate and Company
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        //Candidate and JobTitle
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        //Candidate and Industry
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }



    }
}
