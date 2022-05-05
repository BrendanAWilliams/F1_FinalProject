using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1_FinalProject.Models;

namespace F1_FinalProject.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly F1_FinalProject.Models.TeamContext _context;

        public DetailsModel(F1_FinalProject.Models.TeamContext context)
        {
            _context = context;
        }

        public Team Team { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Team = await _context.Teams.Include(t => t.Drivers).FirstOrDefaultAsync(m => m.TeamID == id);

            if (Team == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
