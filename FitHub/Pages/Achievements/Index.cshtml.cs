using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FitHub.Data;
using FitHub.Models;

namespace FitHub.Pages.Achievements
{
    public class IndexModel : PageModel
    {
        private readonly FitHub.Data.FitHubContext _context;

        public IndexModel(FitHub.Data.FitHubContext context)
        {
            _context = context;
        }

        public IList<Achievement> Achievement { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Achievement = await _context.Achievements
                .Include(a => a.User).ToListAsync();
        }
    }
}
