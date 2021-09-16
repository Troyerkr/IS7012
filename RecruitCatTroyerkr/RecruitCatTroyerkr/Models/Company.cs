using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionName { get; set; }
        public string Location { get; set; }
        //Added
        public int NumberOfEmployees { get; set; }
        //Company and Candidates
        public List<Candidate> Candidates { get; set; }
        //Company and Industry
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
