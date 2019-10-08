using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Models
{
	[PublicAPI]
	public class Vector3 : Vector2
	{
		/// <summary>
		/// Gets or sets the position on the Z axis.
		/// </summary>
		/// <value>
		/// The position on the Z axis.
		/// </value>
		[Required]
		public float Z { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Vector3" /> class.
		/// </summary>
		public Vector3() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Vector3" /> class.
		/// </summary>
		/// <param name="x">The position on the X axis.</param>
		/// <param name="y">The position on the Y axis.</param>
		/// <param name="z">The position on the Z axis.</param>
		public Vector3(float x, float y, float z) : base(x, y)
		{
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
		/// Determines whether the specified <see cref="Vector3" />, is equal to this instance.
		/// </summary>
		/// <param name="pos">The <see cref="Vector3" /> to compare with this instance.</param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="Vector3" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		protected bool Equals(Vector3 pos) => this.X.Equals(pos.X) && this.Y.Equals(pos.Y) && this.Z.Equals(pos.Z);

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
			return obj.GetType() == GetType() && Equals((Vector3)obj);
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() => ToString().GetHashCode();

		/// <summary>This method determines whether two Vectors have the same value.</summary>
		/// <seealso cref="operator!=" />
		/// <seealso cref="Equals" />
		public static bool operator ==(Vector3 a, Vector3 b)
		{
			if ((object)a == null) return (object)b == null;
			return a.Equals(b);
		}

		/// <summary>This method determines whether two Vectors do not have the same value.</summary>
		/// <seealso cref="operator==" />
		/// <seealso cref="Equals" />
		public static bool operator !=(Vector3 a, Vector3 b) => !(a == b);
	}
}
