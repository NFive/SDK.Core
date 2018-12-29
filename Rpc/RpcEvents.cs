using JetBrains.Annotations;

namespace NFive.SDK.Core.Rpc
{
	/// <summary>
	/// Core NFive events which are sent over RPC.
	/// </summary>
	[PublicAPI]
	public static class RpcEvents
	{
		/// <summary>
		/// The client initialize event which is fired as soon as a client initializes.
		/// </summary>
		public const string ClientInitialize = "nfive:core:clientInitialize";

		/// <summary>
		/// The client initialized event which is fired as soon as a client has initialized.
		/// </summary>
		public const string ClientInitialized = "nfive:core:clientInitialized";

		/// <summary>
		/// The client plugins event which is fired after client initialization to request plugin information.
		/// </summary>
		public const string ClientPlugins = "nfive:core:clientPlugins";

		/// <summary>
		/// The event which is fired when a new message is sent from a client.
		/// </summary>
		public const string ChatSendMessage = "nfive:core:chat:sendmessage";
	}
}
