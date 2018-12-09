using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models.Player
{
	/// <summary>
	/// User model representing the player on the server.
	/// </summary>
	/// <seealso cref="IdentityModel" />
	[PublicAPI]
	public class User : IdentityModel
	{
		/// <summary>
		/// Gets or sets the license.
		/// </summary>
		/// <value>
		/// The license.
		/// </value>
		[Required]
		[StringLength(40, MinimumLength = 40)] // TODO: Confirm
		public string License { get; set; }

		/// <summary>
		/// Gets or sets the Steam identifier.
		/// </summary>
		/// <value>
		/// The Steam identifier.
		/// </value>
		public long? SteamId { get; set; }

		/// <summary>
		/// Gets or sets the player name.
		/// </summary>
		/// <value>
		/// The player name.
		/// </value>
		[Required]
		[StringLength(32, MinimumLength = 1)] // TODO: Confirm
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the sessions.
		/// </summary>
		/// <value>
		/// The sessions.
		/// </value>
		[InverseProperty("User")]
		public virtual List<Session> Sessions { get; set; }
	}
}
