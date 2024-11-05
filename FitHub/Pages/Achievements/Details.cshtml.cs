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
    public class DetailsModel : PageModel
    {
        private readonly FitHub.Data.FitHubContext _context;

        public DetailsModel(FitHub.Data.FitHubContext context)
        {
            _context = context;
        }

        public Achievement Achievement { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var achievement = await _context.Achievements.FirstOrDefaultAsync(m => m.AchievementId == id);
            if (achievement == null)
            {
                return NotFound();
            }
            else
            {
                Achievement = achievement;
            }
            return Page();
        }
    }
}
