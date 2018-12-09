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
		/// Initializes a new instance of the <see cref="Position"/> class.
		/// </summary>
		public Position() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Position"/> class.
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

		protected bool Equals(Position other)
		{
			return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((Position) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = this.X.GetHashCode();
				hashCode = (hashCode * 397) ^ this.Y.GetHashCode();
				hashCode = (hashCode * 397) ^ this.Z.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(Position a, Position b)
		{
			if ((object)a == null) return (object)b == null;
			return a.Equals(b);
		}

		public static bool operator !=(Position a, Position b)
		{
			return !(a == b);
		}
	}
}
