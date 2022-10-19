using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models
{
	/// <summary>
	/// Routing bucket model representing a game routing bucket.
	/// </summary>
	/// <seealso cref="IdentityModel" />
	[PublicAPI]
	public class RoutingBucket : IdentityModel
	{
		/// <summary>
		/// Gets or sets the <see cref="RoutingBucket"/> name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="RoutingBucket"/> id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		public new uint Id { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether game world population is enabled inside this bucket.
		/// </summary>
		/// <value>
		///   <c>true</c> if [population enabled]; otherwise, <c>false</c>.
		/// </value>
		public bool PopulationEnabled { get; set; }

		/// <summary>
		/// Gets or sets the lockdown mode.
		/// </summary>
		/// <value>
		/// The lockdown mode.
		/// </value>
		public EntityLockdownMode LockdownMode { get; set; }

		/// <summary>
		/// The game's default routing bucket
		/// </summary>
		public static RoutingBucket Default = new RoutingBucket()
		{
			Name = "Default",
			Created = DateTime.UtcNow,
			Id = 0,
			PopulationEnabled = true,
			LockdownMode = EntityLockdownMode.Inactive
		};
	}
}
