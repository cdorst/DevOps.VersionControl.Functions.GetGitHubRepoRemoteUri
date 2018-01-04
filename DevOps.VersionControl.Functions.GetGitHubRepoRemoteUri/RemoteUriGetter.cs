using Common.Structures.HttpBasicAuthentication;
using DevOps.VersionControl.Structures.GitHub;
using System;
using static Metaproject.Users.CDorst.GitHubAccessToken.GitHubCredentials;

namespace DevOps.VersionControl.Functions.GetGitHubRepoRemoteUri
{
    public static class RemoteUriGetter
    {
        private const string cdorst = nameof(cdorst);
        private const string Root = "https://github.com/";

        public static Uri RemoteUri(AccountRepository accountRepository)
            => new Uri($"{accountRepository.Uri}.git");

        public static Uri RemoteUri(string repository, string account = cdorst)
            => RemoteUri(new AccountRepository(account, repository));

        public static Uri RemoteUri(string repository, BasicAuthenticationCredentials? credentials)
            => RemoteUri((credentials ?? CDorst).User, repository);
    }
}
