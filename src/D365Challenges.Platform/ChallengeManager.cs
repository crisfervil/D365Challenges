using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace D365Challenges.Platform
{
	public class ChallengeManager
	{
		private Assembly[] _challengeAssemblies;

		public ChallengeManager(Assembly[] challengeAssemblies)
		{
			_challengeAssemblies = challengeAssemblies;
		}

		public IEnumerable<String> GetChallenges()
		{
			var availableTypesArray = _challengeAssemblies.Select(a => a.GetTypes());
			var availableTypes = new List<Type>();
			var availableChallenges = new List<Type>();

			foreach (Type[] typeArr in availableTypesArray)
			{
				availableTypes.AddRange(typeArr);
			}

			foreach(var type in availableTypes)
			{
				var challengeAttr = type.GetCustomAttribute(typeof(ChallengeAttribute), false);
				Console.WriteLine(type.Name);
				if (challengeAttr != null)
				{
					availableChallenges.Add(type);
				}
			}

			return availableChallenges.Select(c => c.Name).ToList();
		}

		public void Resolve(string code, string challengeName)
		{
		}
	}
}
