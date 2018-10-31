using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class Version
	{
		public int Major { get; set; }

		public int Minor { get; set; }

		public int Patch { get; set; }

		public string PreRelease { get; set; }

		public string Build { get; set; }

		public override string ToString()
		{
			return $"{this.Major}.{this.Minor}.{this.Patch}{(this.PreRelease == null ? string.Empty : $"-{this.PreRelease}")}{(this.Build == null ? string.Empty : $"+{this.Build}")}";
		}
	}
}
