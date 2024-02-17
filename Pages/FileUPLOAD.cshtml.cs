using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;

namespace CRUDCORE.Pages
{
    public class FileUPLOADModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public FileUPLOADModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public IFormFile FileInput { get; set; }

        public string ResultMessage { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {
            // Initialization, if needed
        }

        public IActionResult OnPost()
        {
            if (FileInput == null || FileInput.Length == 0)
            {
                ErrorMessage = "Please select a valid Excel file.";
                return Page();
            }

            try
            {
                // Save the uploaded file to a temporary location
                var tempFilePath = Path.Combine(_environment.WebRootPath, "temp", FileInput.FileName);
                using (var fileStream = new FileStream(tempFilePath, FileMode.Create))
                {
                    FileInput.CopyTo(fileStream);
                }

                // Convert Excel to XML
                string xmlFilePath = Path.Combine(_environment.WebRootPath, "temp", "output.xml");
                var converter = new ExcelToXmlConverter();
                converter.ConvertXlsxToXml(tempFilePath, xmlFilePath);

                // Clean up the temporary Excel file
                System.IO.File.Delete(tempFilePath);

                ResultMessage = "Conversion completed successfully!";
            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error during conversion: {ex.Message}";
            }

            return Page();
        }
    }
}
