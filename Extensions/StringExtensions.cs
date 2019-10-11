using System.Globalization;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Extensions
{
	[PublicAPI]
	public static class StringExtensions
	{
		public static string Pluralize(this string str, int value, string extension = "s", CultureInfo culture = null)
		{
			var val = value.ToString(culture ?? CultureInfo.InvariantCulture);
			return value == 1 ? $"{val} {str}" : $"{val} {str}{extension}";
		}
	}
}
