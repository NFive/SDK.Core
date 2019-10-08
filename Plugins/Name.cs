using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace NFive.SDK.Core.Plugins
{
	/// <summary>
	/// Represents a plugin name, composed of the vendor and project.
	/// </summary>
	[Serializable]
	[PublicAPI]
	public class Name
	{
		/// <summary>
		/// Gets or sets the plugin name vendor.
		/// </summary>
		/// <value>
		/// The plugin name vendor.
		/// </value>
		public string Vendor { get; set; }

		/// <summary>
		/// Gets or sets the plugin name project.
		/// </summary>
		/// <value>
		/// The plugin name project.
		/// </value>
		public string Project { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Name" /> class.
		/// </summary>
		[JsonConstructor]
		public Name() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Name" /> class from a name string.
		/// </summary>
		/// <param name="value">The plugin name string.</param>
		/// <exception cref="ArgumentNullException">Plugin name must be in \"vendor/project\" format.</exception>
		/// <exception cref="ArgumentException">Invalid plugin name format, plugin name must be in \"vendor/project\" format.</exception>
		public Name(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), "Plugin name must be in \"vendor/project\" format.");

			var parts = value.Split('/');

			if (parts.Length != 2) throw new ArgumentException("Invalid plugin name format, plugin name must be in \"vendor/project\" format.", nameof(value));

			this.Vendor = parts[0];
			this.Project = parts[1];
		}

		/// <summary>
		/// Returns a formatted <see cref="string" /> that represents this plugin name.
		/// </summary>
		/// <returns>
		/// A formatted <see cref="string" /> that represents this plugin name.
		/// </returns>
		public override string ToString() => $"{this.Vendor}/{this.Project}";

		/// <summary>
		/// Determines whether the specified <see cref="object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
		/// <returns>
		/// <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (!(obj is Name item)) return false;

			return ToString().Equals(item.ToString());
		}

		/// <summary>
		/// Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode() => ToString().GetHashCode();

		/// <summary>This method determines whether two Names have the same value.</summary>
		/// <seealso cref="operator!=" />
		/// <seealso cref="Equals" />
		public static bool operator ==(Name a, Name b)
		{
			if (a is null) return b is null;

			return a.Equals(b);
		}

		/// <summary>This method determines whether two Names do not have the same value.</summary>
		/// <seealso cref="operator==" />
		/// <seealso cref="Equals" />
		public static bool operator !=(Name a, Name b) => !(a == b);

		/// <summary>
		/// Performs an implicit conversion from <see cref="string" /> to <see cref="Name" />.
		/// </summary>
		/// <param name="value">The string to convert.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator Name(string value) => new Name(value);

		/// <summary>
		/// Performs an implicit conversion from <see cref="Name" /> to <see cref="string" />.
		/// </summary>
		/// <param name="value">The value to convert.</param>
		/// <returns>
		/// The result of the conversion.
		/// </returns>
		public static implicit operator string(Name value) => value.ToString();
	}
}
