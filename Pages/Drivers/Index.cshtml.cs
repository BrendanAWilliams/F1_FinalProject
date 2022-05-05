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
    public class IndexModel : PageModel
    {
        private readonly F1_FinalProject.Models.TeamContext _context;

        public IndexModel(F1_FinalProject.Models.TeamContext context)
        {
            _context = context;
        }

        public IList<Driver> Driver { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;
        
        public async Task OnGetAsync()
        {
            Driver = await _context.Drivers
                .Include(d => d.Team).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
