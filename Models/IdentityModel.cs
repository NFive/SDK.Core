using JetBrains.Annotations;
using NFive.SDK.Core.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace NFive.SDK.Core.Models
{
	/// <inheritdoc />
	/// <summary>
	/// Represents the key properties for a stored model.
	/// </summary>
	[PublicAPI]
	public abstract class IdentityModel : IIdentityModel
	{
		/// <inheritdoc />
		/// <summary>
		/// Gets or sets the model identifier.
		/// </summary>
		/// <value>
		/// The model identifier.
		/// </value>
		[Key]
		[Required]
		public Guid Id { get; set; }

		/// <inheritdoc />
		/// <summary>
		/// Gets or sets the timestamp of when the model was created.
		/// </summary>
		/// <value>
		/// The timestamp of when the model was created.
		/// </value>
		[Required]
		public DateTime Created { get; set; }

		/// <inheritdoc />
		/// <summary>
		/// Gets or sets the timestamp of when the model was deleted.
		/// </summary>
		/// <value>
		/// The timestamp of when the model was deleted.
		/// </value>
		public DateTime? Deleted { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="IdentityModel"/> class.
		/// </summary>
		protected IdentityModel()
		{
			this.Id = GuidGenerator.GenerateTimeBasedGuid();
			this.Created = DateTime.UtcNow;
		}
	}
}
