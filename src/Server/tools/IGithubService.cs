namespace Server.tools;

public interface IGithubService
{
    Task<int> GetTotalCommits(string owner, string repo);
    Task<int> GetTotalPullRequests(string owner, string repo);
    Task<int> GetTotalIssues(string owner, string repo);

    Task<bool> CreateNewBranch(string branchName);


    //content to one feature

    Task<bool> DeleteBranch(string branchName);
    Task<bool> RenameBranch(string branchName);


}
