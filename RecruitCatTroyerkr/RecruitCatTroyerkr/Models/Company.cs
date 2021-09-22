using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Position Name")]
        public string PositionName { get; set; }

        [Required]
        //I added the @ symbol to make it a raw string
        [RegularExpression(@"\w.+, [a-zA-Z]{2}", ErrorMessage = "Enter location as 'City, State Abbrivation'")]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [Range(1,Int32.MaxValue)]
        [DisplayName("Number of Employees")]
        public int NumberOfEmployees { get; set; }

        //Company and Candidates
        public List<Candidate> Candidates { get; set; }

        //Company and Industry
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
