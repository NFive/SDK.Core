using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Helpers;
using NFive.SDK.Core.Models;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Core.Chat
{
	[PublicAPI]
	public class ChatMessage : IChatMessage
	{
		public Guid Id { get; set; }

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
