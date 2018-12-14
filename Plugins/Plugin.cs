using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Plugins
{
	/// <summary>
	/// Represents a NFive plugin configuration.
	/// </summary>
	[PublicAPI]
	[Serializable]
	public class Plugin
	{
		/// <summary>
		/// Gets or sets the plugin name.
		/// </summary>
		/// <remarks>
		/// The plugin name must be globally unique.
		/// </remarks>
		/// <value>
		/// The plugin name.
		/// </value>
		public Name Name { get; set; }

		/// <summary>
		/// Gets or sets the plugin version.
		/// </summary>
		/// <value>
		/// The plugin version.
		/// </value>
		public Version Version { get; set; }

		/// <summary>
		/// Gets the full plugin name.
		/// </summary>
		/// <value>
		/// The full plugin name, composed of the <see cref="Name"/> and <see cref="Version"/>.
		/// </value>
		public string FullName => $"{this.Name}@{this.Version}";

		/// <summary>
		/// Gets or sets the plugin description.
		/// </summary>
		/// <value>
		/// The plugin description.
		/// </value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the plugin author.
		/// </summary>
		/// <value>
		/// The plugin author.
		/// </value>
		public string Author { get; set; }

		/// <summary>
		/// Gets or sets the plugin software license.
		/// </summary>
		/// <value>
		/// The plugin software license.
		/// </value>
		public string License { get; set; }

		/// <summary>
		/// Gets or sets the plugin website.
		/// </summary>
		/// <value>
		/// The plugin website.
		/// </value>
		public string Website { get; set; }

		public Server Server { get; set; }

		public Client Client { get; set; }

		public Dictionary<Name, VersionRange> Dependencies { get; set; }

		public List<Repository> Repositories { get; set; }

		/// <summary>
		/// Returns a <see cref="string" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="string" /> that represents this instance.
		/// </returns>
		public override string ToString() => this.FullName;
	}
}
