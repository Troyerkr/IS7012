using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //Industry and Company
        public List<Company> Companies { get; set; }

        //Industry and Candidate
        public List<Candidate> Candidates { get; set; }
    }
}
