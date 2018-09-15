using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365Challenges.Platform
{
	public interface IChallengeSolution
	{
		void Run(IOrganizationService service);
	}
}
