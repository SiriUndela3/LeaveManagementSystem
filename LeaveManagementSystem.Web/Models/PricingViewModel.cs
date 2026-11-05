namespace LeaveManagementSystem.Web.Models;

public sealed class PricingViewModel
{
    public IReadOnlyList<PricingTierViewModel> Tiers { get; init; } = [];
}
