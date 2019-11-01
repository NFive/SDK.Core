using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Core.Chat
{
	/// <summary>
	/// Represents a chat message sent from a <see cref="User" />.
	/// </summary>
	[PublicAPI]
	public interface IChatMessage
	{
		/// <summary>
		/// Gets or sets the unique identifier of the message.
		/// </summary>
		/// <value>
		/// The unique identifier of the message.
		/// </value>
		Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="User" /> sending the message.
		/// </summary>
		/// <value>
		/// The <see cref="User" /> sending the message.
		/// </value>
		User Sender { get; set; }

		string Style { get; set; }

		string Template { get; set; }

		string[] Values { get; set; }

		[CanBeNull]
		Vector3 Location { get; set; }

		float? Radius { get; set; }
	}
}
