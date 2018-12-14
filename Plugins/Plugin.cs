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

		/// <summary>
		/// Gets or sets the server requirements.
		/// </summary>
		/// <value>
		/// The server requirements.
		/// </value>
		public Server Server { get; set; }

		/// <summary>
		/// Gets or sets the client requirements.
		/// </summary>
		/// <value>
		/// The client requirements.
		/// </value>
		public Client Client { get; set; }

		/// <summary>
		/// Gets or sets the dependencies required by this plugin.
		/// </summary>
		/// <value>
		/// The dependencies required by this plugin.
		/// </value>
		public Dictionary<Name, VersionRange> Dependencies { get; set; }

		/// <summary>
		/// Gets or sets the repositories used to locate dependencies.
		/// </summary>
		/// <value>
		/// The repositories used to locate dependencies.
		/// </value>
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
