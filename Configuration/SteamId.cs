namespace NFive.SDK.Core.Configuration
{
	using JetBrains.Annotations;
	using System;

	[PublicAPI]
	public class SteamId
	{
		protected readonly long Value;

		public SteamId(long id64)
		{
			this.Value = id64;
		}

		public override string ToString() => this.Value.ToString();

		public override int GetHashCode() => this.Value.GetHashCode();

		public override bool Equals(object obj) => Equals(obj as SteamId);

		public bool Equals(SteamId other) => other != null && this.Value == other.Value;

		public static implicit operator long(SteamId id) => id.Value;

		public static explicit operator SteamId(long l) => new SteamId(l);

		public static SteamId FromSteamId32(string id32)
		{
			if (id32.StartsWith("[") && id32.EndsWith("]")) id32 = id32.TrimStart('[').TrimEnd(']');
			if (!id32.StartsWith("U:1:", StringComparison.InvariantCultureIgnoreCase)) throw new ArgumentException("Input not in valid SteamID32 format", nameof(id32));

			var steam32 = Convert.ToInt64(id32.Substring(4));
			if (steam32 < 1L || steam32 > 9999999999L) throw new ArgumentException("Input not in valid SteamID32 format", nameof(id32));

			return new SteamId(steam32 + 76561197960265728L);
		}

		public static SteamId FromSteamId2(string id2)
		{
			if (!id2.StartsWith("STEAM_0:", StringComparison.InvariantCultureIgnoreCase)) throw new ArgumentException("Input not in valid SteamID2 format", nameof(id2));
			if (!id2.Substring(8).StartsWith("0") && !id2.Substring(8).StartsWith("1")) throw new ArgumentException("Input not in valid SteamID2 format", nameof(id2));

			var id = Convert.ToInt64(id2.Substring(10));
			if (id < 1L || id > 9999999999L) throw new ArgumentException("Input not in valid SteamID2 format", nameof(id2));

			return new SteamId(76561197960265728L + id * 2L + Convert.ToInt64(id2.Substring(8, 1)));
		}
	}
}
