namespace Server.tools;

public interface IGithubService
{
    Task<int> GetTotalCommits(string owner, string repo);
    Task<int> GetTotalPullRequests(string owner, string repo);
    Task<int> GetTotalIssues(string owner, string repo);
}
