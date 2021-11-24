using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConfigFileTesting
{
    public class JiraConfigTest
    {
        public string GetConfigData()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("genesisjiraconfig.json", optional: true, reloadOnChange: true)
                .Build();

            var jiraUrl = config.GetSection("Jira")["Url"];
            var basicToken = config.GetSection("Jira")["Token"];
            var tokenLifeTime = config.GetSection("Audience")["ExpireMinutes_access_token"];
            
            return jiraUrl;
        }
    }
}