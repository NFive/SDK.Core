namespace NFive.SDK.Core.Models
{
	using System.ComponentModel.DataAnnotations.Schema;
	using JetBrains.Annotations;

	/// <summary>
	/// Represents an ARGB (alpha, red, green, blue) color.
	/// </summary>
	[PublicAPI]
	[ComplexType]
	public class Color
	{
		/// <summary>
		/// Gets or sets the alpha component value of this <see cref="Color" /> structure.
		/// </summary>
		/// <value>
		/// The alpha component value of this <see cref="Color" /> structure.
		/// </value>
		public byte? A { get; set; }

		/// <summary>
		/// Gets or sets the red component value of this <see cref="Color" /> structure.
		/// </summary>
		/// <value>
		/// The red component value of this <see cref="Color" /> structure.
		/// </value>
		public byte? R { get; set; }

		/// <summary>
		/// Gets or sets the green component value of this <see cref="Color" /> structure.
		/// </summary>
		/// <value>
		/// The green component value of this <see cref="Color" /> structure.
		/// </value>
		public byte? G { get; set; }

		/// <summary>
		/// Gets or sets the blue component value of this <see cref="Color" /> structure.
		/// </summary>
		/// <value>
		/// The blue component value of this <see cref="Color" /> structure.
		/// </value>
		public byte? B { get; set; }
	}
}
