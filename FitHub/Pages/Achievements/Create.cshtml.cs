using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FitHub.Data;
using FitHub.Models;

namespace FitHub.Pages.Achievements
{
    public class CreateModel : PageModel
    {
        private readonly FitHub.Data.FitHubContext _context;

        public CreateModel(FitHub.Data.FitHubContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Achievement Achievement { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Achievements.Add(Achievement);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
