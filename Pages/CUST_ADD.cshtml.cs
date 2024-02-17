using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUDCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDCORE.Pages
{
    public class CUST_ADDModel : PageModel
    {
        private readonly CRUDCORE.DAL.AppDbContext _context;

        public CUST_ADDModel(CRUDCORE.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Cust_Details Cust_Details { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Cust_Details == null || Cust_Details == null)
            {
                return Page();
            }
            var newCustDetail = new Cust_Details
            {
                id = Cust_Details.id,
                Cust_Name = Cust_Details.Cust_Name,
                Cust_Address = Cust_Details.Cust_Address,
                Cust_Email = Cust_Details.Cust_Email,
                Cust_MOBILE = Cust_Details.Cust_MOBILE
            };
            //_context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Cust_Details ON");
            _context.Cust_Details.Add(newCustDetail);
            try
            {
                await _context.SaveChangesAsync();

                // Add JavaScript alert to be executed on the client-side
                TempData["SuccessMessage"] = "Customer details added successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Error adding customer details: {ex.Message}";
            }
            return RedirectToPage("./Index");
        }
    }
}
