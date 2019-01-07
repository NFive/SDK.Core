using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace NFive.SDK.Core.Plugins
{
	/// <summary>
	/// Server file requirements for a plugin.
	/// </summary>
	[PublicAPI]
	[Serializable]
	public class Server
	{
		/// <summary>
		/// Gets or sets the main server plugin file.
		/// </summary>
		/// <value>
		/// The main server plugin file.
		/// </value>
		public List<string> Main { get; set; }

		/// <summary>
		/// Gets or sets the server plugin include files.
		/// </summary>
		/// <value>
		/// The server plugin include files.
		/// </value>
		public List<string> Include { get; set; }
	}
}
