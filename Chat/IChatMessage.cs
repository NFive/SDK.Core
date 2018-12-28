using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Core.Chat
{
	/// <summary>
	/// Represents a chat message sent from a <see cref="User"/>.
	/// </summary>
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
		/// Gets or sets the <see cref="User"/> sending the message.
		/// </summary>
		/// <value>
		/// The <see cref="User"/> sending the message.
		/// </value>
		User Sender { get; set; }

		/// <summary>
		/// Gets or sets the content of the message.
		/// </summary>
		/// <value>
		/// The content of the message.
		/// </value>
		string Content { get; set; }

		/// <summary>
		/// Gets or sets the target <see cref="User"/> of the message.
		/// </summary>
		/// <value>
		/// The target <see cref="User"/> of the message.
		/// </value>
		[CanBeNull] User Target { get; set; }
	}
}
