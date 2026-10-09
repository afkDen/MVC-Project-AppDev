namespace MVC.Models.Portfolio;

public record DanielProfileViewModel(
    string Name,
    string Role,
    string Bio,
    IReadOnlyList<string> Skills,
    IReadOnlyList<string> Interests,
    string GitHubUrl,
    string WebsiteUrl);