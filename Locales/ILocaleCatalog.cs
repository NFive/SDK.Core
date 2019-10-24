using System.Globalization;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Locales
{
	[PublicAPI]
	public interface ILocaleCatalog
	{
		CultureInfo Culture { get; }

		string GetString(string text);

		string _(string text);

		string GetString(string text, params object[] args);

		string _(string text, params object[] args);

		string GetPluralString(string text, string pluralText, long n);

		string _n(string text, string pluralText, long n);

		string GetPluralString(string text, string pluralText, long n, params object[] args);

		string _n(string text, string pluralText, long n, params object[] args);

		string GetParticularString(string context, string text);

		string _p(string context, string text);

		string GetParticularString(string context, string text, params object[] args);

		string _p(string context, string text, params object[] args);

		string GetParticularPluralString(string context, string text, string pluralText, long n);

		string _pn(string context, string text, string pluralText, long n);

		string GetParticularPluralString(string context, string text, string pluralText, long n, params object[] args);

		string _pn(string context, string text, string pluralText, long n, params object[] args);
	}
}
