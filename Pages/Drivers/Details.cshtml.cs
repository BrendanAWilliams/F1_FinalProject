using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using F1_FinalProject.Models;

namespace F1_FinalProject.Pages.Drivers
{
    public class DetailsModel : PageModel
    {
        private readonly F1_FinalProject.Models.TeamContext _context;

        public DetailsModel(F1_FinalProject.Models.TeamContext context)
        {
            _context = context;
        }

        public Driver Driver { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Driver = await _context.Drivers
                .Include(d => d.Team).FirstOrDefaultAsync(m => m.DriverID == id);

            if (Driver == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
