using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace MVC.Tests;

public class DanielTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient client;
    public DanielTests(WebApplicationFactory<Program> factory) => client = factory.CreateClient();

    [Theory]
    [InlineData("/daniel", "Mark Daniel L. Liwanag")]
    [InlineData("/daniel/portfolio", "LakadPapel")]
    [InlineData("/css/daniel.css", ".project-list")]
    public async Task Feature_pages_and_styles_are_served(string path, string expected)
    {
        var response = await client.GetAsync(path);
        response.EnsureSuccessStatusCode();
        Assert.Contains(expected, await response.Content.ReadAsStringAsync());
    }

    [Fact]
    public async Task Only_Daniels_directory_card_is_available()
    {
        var html = await client.GetStringAsync("/team");
        Assert.Contains("href=\"/daniel\"", html);
        Assert.Contains("href=\"/daniel/portfolio\"", html);
        Assert.Equal(2, Regex.Matches(html, "Coming soon").Count);
    }

    [Theory]
    [InlineData("/")]
    [InlineData("/team")]
    [InlineData("/daniel")]
    [InlineData("/daniel/portfolio")]
    public async Task Every_rendered_local_navigation_and_stylesheet_link_resolves(string path)
    {
        var html = await client.GetStringAsync(path);
        var links = Regex.Matches(html, "href=\"(/[^\"]*)\"").Select(match => System.Net.WebUtility.HtmlDecode(match.Groups[1].Value)).Distinct();
        Assert.NotEmpty(links);
        foreach (var link in links)
        {
            var response = await client.GetAsync(link);
            Assert.True(response.IsSuccessStatusCode, path + " links to missing route or asset " + link);
        }
    }
}