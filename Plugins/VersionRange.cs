using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class VersionRange
	{
		public string Value { get; set; }

		public override string ToString()
		{
			return this.Value;
		}
	}
}
