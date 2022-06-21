namespace NFive.SDK.Core.Extensions
{
    using JetBrains.Annotations;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    
	public static class StringExtensions
	{
		public static string Pluralize(this string str, int value, string extension = "s", CultureInfo culture = null)
		{
			var val = value.ToString(culture ?? CultureInfo.InvariantCulture);
			return value == 1 ? $"{val} {str}" : $"{val} {str}{extension}";
		}

		public static string[] SplitArguments(this string str)
		{
			return Regex.Matches(str, @"[\""].+?[\""]|[^ ]+")
				.Cast<Match>()
				.Select(m => m.Value.Trim())
				.Select(m => m.StartsWith("\"") ? m.Substring(1, m.Length - 2) : m)
				.ToArray();
		}
	}
}
