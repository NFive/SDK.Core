using JetBrains.Annotations;

namespace NFive.SDK.Core.Models
{
	/// <summary>
	/// Represents the lockdown mode used by the game's routing bucket
	/// </summary>
	[PublicAPI]
	public enum EntityLockdownMode
	{
		/// <summary>
		/// No entities can be created by clients at all.
		/// </summary>
		[StringValue("strict")]
		Strict = 0,

		/// <summary>
		/// Only script-owned entities created by clients are blocked.
		/// </summary>
		[StringValue("relaxed")]
		Relaxed,

		/// <summary>
		/// Clients can create any entity they want.
		/// </summary>
		[StringValue("inactive")]
		Inactive

	}
}
