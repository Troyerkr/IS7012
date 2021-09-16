using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MinimumSalary { get; set; }
        public int MaximumSalary { get; set; }
        //Added
        public DateTime? ApplicationDeadline { get; set; }
        public bool FullTime { get; set; }
        //JobTitle and Candidate
        public List<Candidate> Candidates { get; set; }
    }
}
