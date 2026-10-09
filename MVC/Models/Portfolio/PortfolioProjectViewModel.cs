namespace MVC.Models.Portfolio;

public record PortfolioProjectViewModel(
    string Title,
    string Category,
    string Description,
    string Role,
    IReadOnlyList<string> Technologies,
    string RepositoryUrl,
    string? LiveUrl = null);

public record DanielPortfolioViewModel(string Name, IReadOnlyList<PortfolioProjectViewModel> Projects);