using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	[Serializable]
	public class Client
	{
		/// <summary>
		/// Gets or sets the main client plugin file.
		/// </summary>
		/// <value>
		/// The main client plugin file.
		/// </value>
		public List<string> Main { get; set; }

		/// <summary>
		/// Gets or sets the client plugin include files.
		/// </summary>
		/// <value>
		/// The client plugin include files.
		/// </value>
		public List<string> Include { get; set; }

		/// <summary>
		/// Gets or sets the client plugin general files.
		/// </summary>
		/// <value>
		/// The client plugin general files.
		/// </value>
		public List<string> Files { get; set; }

		/// <summary>
		/// Gets or sets the client plugin overlay files.
		/// </summary>
		/// <value>
		/// The client plugin overlay files.
		/// </value>
		public List<string> Overlays { get; set; }

		/// <summary>
		/// Gets or sets the client plugin loading screen file.
		/// </summary>
		/// <value>
		/// The client plugin loading screen file.
		/// </value>
		public string LoadingScreen { get; set; }
	}
}
