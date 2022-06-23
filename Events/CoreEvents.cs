namespace NFive.SDK.Core.Events
{
	using JetBrains.Annotations;

	/// <summary>
	/// Core NFive events.
	/// </summary>
	[PublicAPI]
	public static class CoreEvents
	{
		/// <summary>
		/// The event that is fired as soon as a client initializes.
		/// </summary>
		public const string ClientInitialize = "nfive:core:clientInitialize";

		/// <summary>
		/// The event that is fired as soon as a client has initialized.
		/// </summary>
		public const string ClientInitialized = "nfive:core:clientInitialized";

		/// <summary>
		/// The event that is fired after client initialization to request plugin information.
		/// </summary>
		public const string ClientPlugins = "nfive:core:clientPlugins";

		public const string CommandDispatch = "nfive:command:dispatch";

		/// <summary>
		/// The event that is fired when the client is relaying a log message to the server.
		/// </summary>
		public const string LogMirror = "nfive:log:mirror";
	}
}
