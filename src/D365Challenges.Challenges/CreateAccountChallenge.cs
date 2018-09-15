using D365Challenges.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365Challenges.Challenges
{
	/// <summary>
	/// Add a description of the challenge here
	/// </summary>
	[Challenge("Create Account")]
    public class CreateAccountChallenge
    {
		public void Account_Exists(IChallengeSolution solution)
		{
			// prepare the input
			var fakedContext = new FakeXrmEasy.XrmFakedContext();

			// Prepare the data
			// no data to prepare in this case

			solution.Run(fakedContext.GetOrganizationService());

			// check the output
			// There has to be an account created
			if (!fakedContext.Data.ContainsKey("account") || fakedContext.Data["account"].Count == 0)
				throw new Exception("No accounts were created");
		}

    }

}


