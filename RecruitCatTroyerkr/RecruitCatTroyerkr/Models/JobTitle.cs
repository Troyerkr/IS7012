using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Minimum Salary")]
        public int MinimumSalary { get; set; }
        [DisplayName("Maximum Salary")]
        public int MaximumSalary { get; set; }
        //Added
        [DisplayName("Application Deadline")]
        public DateTime? ApplicationDeadline { get; set; }
        [DisplayName("Full Time")]
        public bool FullTime { get; set; }
        //JobTitle and Candidate
        public List<Candidate> Candidates { get; set; }
    }
}
