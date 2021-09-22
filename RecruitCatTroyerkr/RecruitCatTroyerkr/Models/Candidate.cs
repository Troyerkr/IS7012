using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Target Salary")]
        public int TargetSalary { get; set; }
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }
        //Added
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [DisplayName("Birthday")]
        public DateTime DateOfBirth { get; set; }
        //Candidate and Company
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        //Candidate and JobTitle
        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        //Candidate and Industry
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
