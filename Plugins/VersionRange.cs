namespace NFive.SDK.Core.Plugins
{
    using JetBrains.Annotations;
    using System;

	[Serializable]
	
	public class VersionRange
	{
		/// <summary>
		/// Gets or sets the version range.
		/// </summary>
		/// <value>
		/// The version range.
		/// </value>
		public string Value { get; set; }

		/// <summary>
		/// Returns a <see cref="string" /> that represents this version range.
		/// </summary>
		/// <returns>
		/// A <see cref="string" /> that represents this version range.
		/// </returns>
		public override string ToString() => this.Value;
	}
}
