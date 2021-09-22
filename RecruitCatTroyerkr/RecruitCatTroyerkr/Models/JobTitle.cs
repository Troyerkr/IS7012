using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(12000,100000000)]
        [DisplayName("Minimum Salary")]
        public int MinimumSalary { get; set; }

        [Required]
        [Range(12000, 100000000)]
        [DisplayName("Maximum Salary")]
        public int MaximumSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Application Deadline")]
        public DateTime? ApplicationDeadline { get; set; }

        [Required]
        [DisplayName("Full Time")]
        public bool FullTime { get; set; }

        //JobTitle and Candidate
        public List<Candidate> Candidates { get; set; }
    }
}
