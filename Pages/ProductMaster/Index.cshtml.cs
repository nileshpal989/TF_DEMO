using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDCORE.DAL;
using CRUDCORE.Models;

namespace CRUDCORE.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly CRUDCORE.DAL.AppDbContext _context;

        public IndexModel(CRUDCORE.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Products = await _context.Products.ToListAsync();
            }
        }
    }
}
