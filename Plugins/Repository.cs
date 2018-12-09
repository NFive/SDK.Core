using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	[Serializable]
	public class Repository
	{
		public Name Name { get; set; }

		public string Type { get; set; }

		public string Path { get; set; }

		public string Url { get; set; }
	}
}
