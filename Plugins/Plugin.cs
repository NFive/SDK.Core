using System.Collections.Generic;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class Plugin
	{
		public Name Name { get; set; }

		public Version Version { get; set; }

		public string FullName => $"{this.Name}@{this.Version}";

		public string Description { get; set; }

		public string Author { get; set; }

		public string License { get; set; }

		public string Website { get; set; }

		public Server Server { get; set; }

		public Client Client { get; set; }

		public Dictionary<Name, VersionRange> Dependencies { get; set; }

		public List<Repository> Repositories { get; set; }

		public override string ToString()
		{
			return this.FullName;
		}
	}
}
