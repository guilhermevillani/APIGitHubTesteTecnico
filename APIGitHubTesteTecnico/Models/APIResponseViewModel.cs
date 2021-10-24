using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIGitHubTesteTecnico.Models
{
    /// <summary>
    /// API response formatter. Creating single object to return 5 difrent items from the list
    /// </summary>
    public class APIResponseViewModel
    {
        public string Avatar { get; set; }

        public string Name1 { get; set; }
        public string Description1 { get; set; }

        public string Name2 { get; set; }
        public string Description2{ get; set; }

        public string Name3{ get; set; }
        public string Description3{ get; set; }

        public string Name4{ get; set; }
        public string Description4 { get; set; }

        public string Name5 { get; set; }
        public string Description5 { get; set; }    

    }
}