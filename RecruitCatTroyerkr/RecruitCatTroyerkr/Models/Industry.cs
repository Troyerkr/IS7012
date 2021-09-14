using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Industry and Company
        public List<Company> Companies { get; set; }
        //Industry and Candidate
        public List<Candidate> Candidates { get; set; }
    }
}
