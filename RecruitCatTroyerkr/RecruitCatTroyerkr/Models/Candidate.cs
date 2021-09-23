using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTroyerkr.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Target Salary")]
        [Range(12000, 100000000)]
        public int TargetSalary { get; set; }


        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [StringLength(11)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("Birthday")]
        [DataType(DataType.Date)]
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

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
