using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace NFive.SDK.Core.Plugins
{
	[PublicAPI]
	public class Name
	{
		public string Vendor { get; set; }

		public string Project { get; set; }

		[JsonConstructor]
		public Name() { }

		public Name(string value)
		{
			if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));

			var parts = value.Split('/');

			if (parts.Length != 2) throw new ArgumentException("Invalid plugin name format", nameof(value));

			this.Vendor = parts[0];
			this.Project = parts[1];
		}

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString() => $"{this.Vendor}/{this.Project}";

		/// <summary>Determines whether the specified object is equal to the current object.</summary>
		/// <param name="obj">The object to compare with the current object. </param>
		/// <returns>
		/// <see langword="true" /> if the specified object is equal to the current object; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			if (!(obj is Name item)) return false;

			return ToString().Equals(item.ToString());
		}

		/// <summary>Serves as the default hash function. </summary>
		/// <returns>A hash code for the current object.</returns>
		public override int GetHashCode() => ToString().GetHashCode();

		public static bool operator ==(Name a, Name b)
		{
			if (a is null) return b is null;
			return a.Equals(b);
		}

		public static bool operator !=(Name a, Name b) => !(a == b);

		public static implicit operator Name(string value) => new Name(value);

		public static implicit operator string(Name value) => value.ToString();
	}
}
