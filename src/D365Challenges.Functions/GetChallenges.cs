
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Reflection;
using D365Challenges.Challenges;
using D365Challenges.Platform;

namespace D365Challenges.Functions
{
    public static class GetChallenges
    {
        [FunctionName("GetChallenges")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

			var challengeAssemblies = new Assembly[] { typeof(CreateAccountChallenge).Assembly };
			var challengeMgr = new ChallengeManager(challengeAssemblies);
			var challenges = challengeMgr.GetChallenges();

			log.LogInformation("Available Challenges:");
			foreach (var challengeName in challenges)
			{
				log.LogInformation(challengeName);
			}

			return (ActionResult)new OkObjectResult(challenges);
        }
    }
}
