using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Server.utils;

namespace Server.tools;

public class GithubService : IGithubService
{
    private readonly ILogger _logger = LoggerProvider.CreateLogger();

    public void CreateIssue(string title, string description)
    {
        _logger.LogInformation("Creating GitHub issue: {Title}", title);
        // Logic to create a GitHub issue
    }

    public void CloseIssue(int issueId)
    {
        _logger.LogInformation("Closing GitHub issue: {IssueId}", issueId);
        // Logic to close a GitHub issue
    }

    public Task<int> GetTotalCommits(string owner, string repo)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalPullRequests(string owner, string repo)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetTotalIssues(string owner, string repo)
    {
        throw new NotImplementedException();
    }
}