using System.Collections.Generic;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class Client
	{
		public List<string> Main { get; set; }

		public List<string> Include { get; set; }

		public List<string> Files { get; set; }

		public List<string> Overlays { get; set; }

		public string LoadingScreen { get; set; }
	}
}
