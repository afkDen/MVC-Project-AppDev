namespace MVC.Models;

public record TeamMemberViewModel(string Name, string Initials, string? Controller = null)
{
    public bool IsAvailable => Controller is not null;
}