using System.Collections.Generic;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class Server
	{
		public List<string> Main { get; set; }

		public List<string> Include { get; set; }
	}
}
