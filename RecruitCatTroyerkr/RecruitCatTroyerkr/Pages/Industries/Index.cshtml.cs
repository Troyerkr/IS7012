using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatTroyerkr.Data;
using RecruitCatTroyerkr.Models;

namespace RecruitCatTroyerkr.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatTroyerkr.Data.RecruitCatTroyerkrContext _context;

        public IndexModel(RecruitCatTroyerkr.Data.RecruitCatTroyerkrContext context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get;set; }

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
