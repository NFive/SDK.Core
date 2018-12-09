using System;

namespace NFive.SDK.Core.Plugins
{
	/// <summary>
	/// A semantic version number.
	/// </summary>
	[Serializable]
	public class Version
	{
		/// <summary>
		/// Gets or sets the major version number.
		/// </summary>
		/// <value>
		/// The major version number.
		/// </value>
		public int Major { get; set; }

		/// <summary>
		/// Gets or sets the minor version number.
		/// </summary>
		/// <value>
		/// The minor version number.
		/// </value>
		public int Minor { get; set; }

		/// <summary>
		/// Gets or sets the patch version number.
		/// </summary>
		/// <value>
		/// The patch version number.
		/// </value>
		public int Patch { get; set; }

		/// <summary>
		/// Gets or sets the pre release version.
		/// </summary>
		/// <value>
		/// The pre release version.
		/// </value>
		public string PreRelease { get; set; }

		/// <summary>
		/// Gets or sets the build version.
		/// </summary>
		/// <value>
		/// The build version.
		/// </value>
		public string Build { get; set; }

		/// <summary>
		/// Returns a formatted <see cref="string" /> that represents this version number.
		/// </summary>
		/// <returns>
		/// A formatted <see cref="string" /> that represents this version number.
		/// </returns>
		public override string ToString()
		{
			return $"{this.Major}.{this.Minor}.{this.Patch}{(this.PreRelease == null ? string.Empty : $"-{this.PreRelease}")}{(this.Build == null ? string.Empty : $"+{this.Build}")}";
		}
	}
}
