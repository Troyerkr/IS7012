using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatTroyerkr.Data;
using RecruitCatTroyerkr.Models;

namespace RecruitCatTroyerkr.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatTroyerkr.Data.RecruitCatTroyerkrContext _context;

        public IndexModel(RecruitCatTroyerkr.Data.RecruitCatTroyerkrContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
