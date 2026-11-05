using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LeaveManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            var model = new PricingViewModel
            {
                Tiers =
                [
                    new PricingTierViewModel
                    {
                        Name = "Starter",
                        Eyebrow = "For small teams",
                        Description = "The essentials for organizing time off with confidence.",
                        MonthlyPrice = 4,
                        Audience = "Best for teams up to 25 people",
                        Features =
                        [
                            "Employee leave requests",
                            "Manager approval workflow",
                            "Leave balances and history",
                            "Standard leave types",
                            "Email status notifications"
                        ]
                    },
                    new PricingTierViewModel
                    {
                        Name = "Team",
                        Eyebrow = "For growing organizations",
                        Description = "More visibility and flexibility for teams that are scaling.",
                        MonthlyPrice = 8,
                        Audience = "Best for teams up to 150 people",
                        IsFeatured = true,
                        Features =
                        [
                            "Everything in Starter",
                            "Custom leave policies",
                            "Team and department calendars",
                            "Holiday calendar management",
                            "Reporting and export tools"
                        ]
                    },
                    new PricingTierViewModel
                    {
                        Name = "Business",
                        Eyebrow = "For complex organizations",
                        Description = "Advanced controls for distributed teams and detailed policies.",
                        MonthlyPrice = 14,
                        Audience = "Best for teams over 150 people",
                        Features =
                        [
                            "Everything in Team",
                            "Multiple departments and approvers",
                            "Advanced roles and permissions",
                            "Audit history and activity logs",
                            "Priority implementation support"
                        ]
                    }
                ]
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
