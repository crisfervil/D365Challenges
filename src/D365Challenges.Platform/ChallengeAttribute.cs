using System;

namespace D365Challenges.Platform
{
	public class ChallengeAttribute : Attribute
	{
		public string Name { get; set; }
		public ChallengeAttribute(string name)
		{
			this.Name = Name;
		}

	}
}