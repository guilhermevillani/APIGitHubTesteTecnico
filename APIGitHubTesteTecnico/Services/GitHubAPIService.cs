using APIGitHubTesteTecnico.Services.ApiHelper;
using GitHubAPITesteTecnico.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIGitHubTesteTecnico.Services
{
    public class GitHubAPIService
    {
        private readonly ApiService _ApiService;
        public GitHubAPIService()
        {
            _ApiService = new ApiService();
        }
        public IEnumerable<Repositories> GetFirstFiveRepositoriesByLanguage(string orgName, string language)
        {

            var url = _ApiService.SetUrl("orgs", orgName, "repos", 100);
            var allRepositories = _ApiService.GetAsync<List<Repositories>>(url).Result;

            if (language.Equals("CSHARP"))
            {
                language = "C#";
            }

            var languageRepositories = allRepositories.Where(r => !string.IsNullOrEmpty(r.Language) && r.Language.Equals(language));
            var firstFiveReps = languageRepositories.OrderBy(c => c.CreationDate).Take(5);

            return firstFiveReps;
        }
    }
}