using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace MVC.Tests;

public class FoundationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient client;
    public FoundationTests(WebApplicationFactory<Program> factory) => client = factory.CreateClient();

    [Theory]
    [InlineData("/", "AppDev group portfolio")]
    [InlineData("/team", "Yeshaya I. Evaristo")]
    [InlineData("/team", "Mitch N. Montales")]
    [InlineData("/css/site.css", "--accent")]
    public async Task Shared_pages_and_styles_are_served(string path, string expected)
    {
        var response = await client.GetAsync(path);
        response.EnsureSuccessStatusCode();
        Assert.Contains(expected, await response.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task Missing_route_returns_not_found() => Assert.Equal(System.Net.HttpStatusCode.NotFound, (await client.GetAsync("/missing-page")).StatusCode);
}