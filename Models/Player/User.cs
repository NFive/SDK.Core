namespace NFive.SDK.Core.Models.Player
{
	using JetBrains.Annotations;
	using System.Collections.Generic;

    /// <inheritdoc />
    /// <summary>
    /// User model representing the player on the server.
    /// </summary>
    /// <seealso cref="IdentityModel" />
    
	public class User : IdentityModel
	{
		/// <summary>
		/// Gets or sets the license.
		/// </summary>
		/// <value>
		/// The license.
		/// </value>
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
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the sessions.
		/// </summary>
		/// <value>
		/// The sessions.
		/// </value>
		public virtual List<Session> Sessions { get; set; }
	}
}
