using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitHubAPITesteTecnico.Models
{
    public class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }
    }
}