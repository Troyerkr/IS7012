using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatTroyerkr.Models;

namespace RecruitCatTroyerkr.Data
{
    public class RecruitCatTroyerkrContext : DbContext
    {
        public RecruitCatTroyerkrContext (DbContextOptions<RecruitCatTroyerkrContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatTroyerkr.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatTroyerkr.Models.Company> Company { get; set; }

        public DbSet<RecruitCatTroyerkr.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatTroyerkr.Models.JobTitle> JobTitle { get; set; }
    }
}
