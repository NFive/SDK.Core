using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Core.Chat
{
	/// <summary>
	/// Represents a chat message sent from a <see cref="User"/>.
	/// </summary>
	[PublicAPI]
	public class ChatMessage
	{
		/// <summary>
		/// Gets or sets the unique identifier of the message.
		/// </summary>
		/// <value>
		/// The unique identifier of the message.
		/// </value>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="User"/> sending the message.
		/// </summary>
		/// <value>
		/// The <see cref="User"/> sending the message.
		/// </value>
		public User Sender { get; set; }

		public string Style { get; set; }

		public string Template { get; set; }

		public string[] Values { get; set; }

		public Vector3 Location { get; set; }

		public float? Radius { get; set; }

		public ChatMessage()
		{
			this.Id = GuidGenerator.GenerateTimeBasedGuid();
		}
	}
}
