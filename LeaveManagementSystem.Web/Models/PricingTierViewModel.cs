namespace LeaveManagementSystem.Web.Models;

public sealed class PricingTierViewModel
{
    public string Name { get; init; } = string.Empty;

    public string Eyebrow { get; init; } = string.Empty;

    public string Description { get; init; } = string.Empty;

    public decimal MonthlyPrice { get; init; }

    public string Audience { get; init; } = string.Empty;

    public bool IsFeatured { get; init; }

    public IReadOnlyList<string> Features { get; init; } = [];
}
