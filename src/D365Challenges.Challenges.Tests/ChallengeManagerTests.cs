using System;
using System.Reflection;
using D365Challenges.Platform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace D365Challenges.Challenges.Tests
{
	[TestClass]
	public class ChallengeManagerTests
	{
		[TestMethod]
		public void GetChallenges()
		{
			var challengeAssemblies = new Assembly[] { this.GetType().Assembly };
			var challengeMgr = new ChallengeManager(challengeAssemblies);
			var challenges = challengeMgr.GetChallenges();

			Assert.IsTrue(challenges.Contains(typeof(MyFakeChallenge).Name));
		}
	}
}
