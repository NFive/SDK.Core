using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace NFive.SDK.Core.Models.Player
{
	/// <summary>
	/// Session model representing a user's connection to the server.
	/// </summary>
	[PublicAPI]
	public class Session
	{
		/// <summary>
		/// Gets or sets the session identifier.
		/// </summary>
		/// <value>
		/// The session identifier.
		/// </value>
		[Key]
		[Required]
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the IP address of the connected client.
		/// </summary>
		/// <value>
		/// The IP address of the connected client.
		/// </value>
		[Required]
		[StringLength(15, MinimumLength = 7)]
		public string IpAddress { get; set; }

		/// <summary>
		/// Gets or sets the timestamp of when the session was created.
		/// </summary>
		/// <value>
		/// The timestamp of when the session was created.
		/// </value>
		[Required]
		public DateTime Created { get; set; } = DateTime.UtcNow;

		/// <summary>
		/// Gets or sets the timestamp of when the client connected to the session.
		/// </summary>
		/// <value>
		/// The timestamp of when the client connected to the session.
		/// </value>
		public DateTime? Connected { get; set; }

		/// <summary>
		/// Gets or sets the timestamp of when the client disconnected from the session.
		/// </summary>
		/// <value>
		/// The timestamp of when the client disconnected from the session.
		/// </value>
		public DateTime? Disconnected { get; set; }

		/// <summary>
		/// Gets or sets the reason the client disconnected.
		/// </summary>
		/// <value>
		/// The reason the client disconnected.
		/// </value>
		[StringLength(200)]
		public string DisconnectReason { get; set; }

		/// <summary>
		/// Gets or sets the user identifier.
		/// </summary>
		/// <value>
		/// The user identifier.
		/// </value>
		[Required]
		[ForeignKey("User")]
		public Guid UserId { get; set; }

		/// <summary>
		/// Gets or sets the user which owns the session.
		/// </summary>
		/// <value>
		/// The user which owns the session.
		/// </value>
		[JsonIgnore]
		public virtual User User { get; set; }

		/// <summary>
		/// Gets a value indicating whether a client is currently connected.
		/// </summary>
		/// <value>
		///   <c>true</c> if a client is currently is connected; otherwise, <c>false</c>.
		/// </value>
		[JsonIgnore]
		public bool IsConnected => this.Connected.HasValue && !this.Disconnected.HasValue;
	}
}
