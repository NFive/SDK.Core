using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models.Player
{
	[PublicAPI]
	public class User : IdentityModel
	{
		[Required]
		[StringLength(40, MinimumLength = 40)] // TODO: Confirm
		public string License { get; set; }

		public long SteamId { get; set; }

		[Required]
		[StringLength(32, MinimumLength = 1)] // TODO: Confirm
		public string Name { get; set; }

		[InverseProperty("User")]
		public virtual List<Session> Sessions { get; set; }
	}
}
