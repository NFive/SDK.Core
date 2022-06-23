namespace NFive.SDK.Core.Plugins
{
	using System;
	using System.Collections.Generic;
	using JetBrains.Annotations;

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
