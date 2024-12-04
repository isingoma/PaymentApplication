using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PaymentPlatform.Pages
{
    [Authorize]  // Only authenticated users can access this page
    public class DashboardModel : PageModel
    {
        // Properties to hold payment form data
        [BindProperty]
        public string Amount { get; set; }

        [BindProperty]
        public string PaymentMethod { get; set; }

        public string PaymentStatusMessage { get; set; }

        // Handle the form submission
        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(Amount) && !string.IsNullOrEmpty(PaymentMethod))
            {
                // Simulate initiating the payment (you could add actual logic here)
                PaymentStatusMessage = $"Payment of {Amount} via {PaymentMethod} initiated successfully!";
            }
            else
            {
                PaymentStatusMessage = "Please fill in all fields to initiate the payment.";
            }

            // Return the same page to show the result
            return Page();
        }
    }
}
