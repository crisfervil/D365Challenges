using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D365Challenges.Platform;
using Microsoft.Xrm.Sdk;

namespace D365Challenges.Challenges
{
	class CreateAccountChallengeSolution : IChallengeSolution
	{
		public void Run(IOrganizationService service)
		{
			var account = new Entity("account") { Id=Guid.NewGuid() };
			account["name"] = "Contoso";
			service.Create(account);
		}
	}
}
