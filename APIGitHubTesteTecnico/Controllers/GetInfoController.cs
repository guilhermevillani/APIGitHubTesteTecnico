using APIGitHubTesteTecnico.Models;
using APIGitHubTesteTecnico.Services;
using GitHubAPITesteTecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace APIGitHubTesteTecnico.Controllers
{
    public class GetInfoController : ApiController
    {
        private readonly GitHubAPIService _gitHubAPIService;
        public GetInfoController()
        {
            _gitHubAPIService = new GitHubAPIService();
        }

        [HttpGet]
        [Route("api/GetFirstFiveRepositoriesByLanguage/{org}/{language}")]
        public APIResponseViewModel GetFirstFiveRepositoriesByLanguage(string org, string language)
        {
            var repositories = _gitHubAPIService.GetFirstFiveRepositoriesByLanguage(org, language.ToUpper()).ToList();

            return new APIResponseViewModel
            {
                Avatar = repositories.First().Owner.AvatarURL,
                Name1 = repositories.ElementAt(0).Name,
                Description1 = repositories.ElementAt(0).Description,
                Name2 = repositories.ElementAt(1).Name,
                Description2 = repositories.ElementAt(1).Description,
                Name3 = repositories.ElementAt(2).Name,
                Description3 = repositories.ElementAt(2).Description,
                Name4 = repositories.ElementAt(3).Name,
                Description4 = repositories.ElementAt(3).Description,
                Name5 = repositories.ElementAt(4).Name,
                Description5 = repositories.ElementAt(4).Description
            };

             
        }
    }
}
