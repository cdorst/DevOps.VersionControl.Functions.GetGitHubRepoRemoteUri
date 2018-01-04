using Common.Structures.HttpBasicAuthentication;
using DevOps.VersionControl.Structures.GitHub;
using System;

namespace DevOps.VersionControl.Functions.GetGitHubRepoRemoteUri
{
    public static class RemoteUriGetter
    {
        private const string Root = "https://github.com/";

        public static Uri RemoteUri(AccountRepository accountRepository)
            => new Uri($"{accountRepository.Uri}.git");

        public static Uri RemoteUri(string account, string repository)
            => RemoteUri(new AccountRepository(account, repository));

        public static Uri RemoteUri(BasicAuthenticationCredentials credentials, string repository)
            => RemoteUri(credentials.User, repository);
    }
}
