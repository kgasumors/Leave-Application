using AspNetCoreHero.ToastNotification.Abstractions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Leave_Application.Data;
using Leave_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Leave_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RequestsDbContext _context;
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };

        public IndexModel(RequestsDbContext context) => _context = context;

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            await _context.Requests.AddAsync(Requests);
            await _context.SaveChangesAsync();

            return RedirectToPage("Requests");
        }

        [BindProperty]
        public Requests Requests { get; set; }
    }
}