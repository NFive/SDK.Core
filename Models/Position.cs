using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models
{
	/// <summary>
	/// Represents a position in 3D space.
	/// </summary>
	[PublicAPI]
	[ComplexType]
	public class Position
	{
		/// <summary>
		/// Gets or sets the position on the X axis.
		/// </summary>
		/// <value>
		/// The position on the X axis.
		/// </value>
		[Required]
		public float X { get; set; }

		/// <summary>
		/// Gets or sets the position on the Y axis.
		/// </summary>
		/// <value>
		/// The position on the Y axis.
		/// </value>
		[Required]
		public float Y { get; set; }

		/// <summary>
		/// Gets or sets the position on the Z axis.
		/// </summary>
		/// <value>
		/// The position on the Z axis.
		/// </value>
		[Required]
		public float Z { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Position" /> class.
		/// </summary>
		public Position() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Position" /> class.
		/// </summary>
		/// <param name="x">The position on the X axis.</param>
		/// <param name="y">The position on the Y axis.</param>
		/// <param name="z">The position on the Z axis.</param>
		public Position(float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		/// <summary>
		/// Returns a <see cref="string" /> that represents this position.
		/// </summary>
		/// <returns>
		/// A <see cref="string" /> that represents this position.
		/// </returns>
		public override string ToString() => $"X: {this.X}, Y: {this.Y}, Z: {this.Z}";

		/// <summary>
		/// Determines whether the specified <see cref="Position" />, is equal to this instance.
		/// </summary>
		/// <param name="pos">The <see cref="Position" /> to compare with this instance.</param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="Position" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		protected bool Equals(Position pos) => this.X.Equals(pos.X) && this.Y.Equals(pos.Y) && this.Z.Equals(pos.Z);

		/// <summary>
		/// Determines whether the specified <see cref="object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((Position)obj);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() => ToString().GetHashCode();

		/// <summary>This method determines whether two Positions have the same value.</summary>
		/// <seealso cref="operator!=" />
		/// <seealso cref="Equals" />
		public static bool operator ==(Position a, Position b)
		{
			if ((object)a == null) return (object)b == null;
			return a.Equals(b);
		}

		/// <summary>This method determines whether two Positions do not have the same value.</summary>
		/// <seealso cref="operator==" />
		/// <seealso cref="Equals" />
		public static bool operator !=(Position a, Position b) => !(a == b);
	}
}
