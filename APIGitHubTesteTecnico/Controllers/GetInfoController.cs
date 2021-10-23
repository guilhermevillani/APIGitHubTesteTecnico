using APIGitHubTesteTecnico.Services;
using GitHubAPITesteTecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public List<Repositories> GetFirstFiveRepositoriesByLanguage(string org, string language)
        {            
            return _gitHubAPIService.GetFirstFiveRepositoriesByLanguage(org, language.ToUpper()).ToList();
        }
    }
}
