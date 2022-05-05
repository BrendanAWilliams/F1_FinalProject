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
    public class IndexModel : PageModel
    {
        private readonly F1_FinalProject.Models.TeamContext _context;

        public IndexModel(F1_FinalProject.Models.TeamContext context)
        {
            _context = context;
        }

        public IList<Team> Team { get;set; }

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        [BindProperty(SupportsGet = true)]
        public string SearchString {get; set;}

        public async Task OnGetAsync()
        {
            var query = _context.Teams.Select(t => t);

            if(!string.IsNullOrEmpty(SearchString))
            {
                query = query.Where(s => s.TeamName.Contains(SearchString));
            }

            switch (CurrentSort)
            {
                case "Name_asc":
                    query = query.OrderBy(t => t.TeamName);
                    break;
                case "Name_desc":
                    query = query.OrderByDescending(t => t.TeamName);
                    break;
                case "Base_asc":
                    query = query.OrderBy(t => t.Base);
                    break;
                case "Base_desc":
                    query = query.OrderByDescending(t => t.Base);
                    break;
                case "Chief_asc":
                    query = query.OrderBy(t => t.Chief);
                    break;
                case "Chief_desc":
                    query = query.OrderByDescending(t => t.Chief);
                    break;
                case "Chasis_asc":
                    query = query.OrderBy(t => t.Chasis);
                    break;
                case "Chasis_desc":
                    query = query.OrderByDescending(t => t.Chasis);
                    break;
                case "PowerUnit_asc":
                    query = query.OrderBy(t => t.PowerUnit);
                    break;
                case "PowerUnit_desc":
                    query = query.OrderByDescending(t => t.PowerUnit);
                    break;
                case "FirstEntry_asc":
                    query = query.OrderBy(t => t.FirstEntry);
                    break;
                case "FirstEntry_desc":
                    query = query.OrderByDescending(t => t.FirstEntry);
                    break;
                case "Championships_asc":
                    query = query.OrderBy(t => t.Championships);
                    break;
                case "Championships_desc":
                    query = query.OrderByDescending(t => t.Championships);
                    break;
            }
            Team = await query.ToListAsync();
        }
    }
}
