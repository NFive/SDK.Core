using System.Globalization;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Locales
{
	/// <summary>
	/// A GNU gettext locale catalog for a given culture.
	/// </summary>
	[PublicAPI]
	public interface ILocaleCatalog
	{
		/// <summary>Gets the catalog culture.</summary>
		/// <value>The catalog culture.</value>
		CultureInfo Culture { get; }

		/// <summary>
		/// Returns <paramref name="text"/> translated into the catalog language.
		/// </summary>
		/// <param name="text">The text to translate.</param>
		/// <returns>The translated text.</returns>
		string GetString(string text);

		/// <summary>
		/// Alias of <see cref="GetString(string)"/>.
		/// Returns <paramref name="text"/> translated into the catalog language.
		/// </summary>
		/// <param name="text">The text to translate.</param>
		/// <returns>The translated text.</returns>
		string _(string text);

		/// <summary>
		/// Returns <paramref name="text"/> translated into the catalog language.
		/// </summary>
		/// <param name="text">The text to translate.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string GetString(string text, params object[] args);

		/// <summary>
		/// Alias of <see cref="GetString(string, object[])"/>.
		/// Returns <paramref name="text"/> translated into the catalog language.
		/// </summary>
		/// <param name="text">The text to translate.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string _(string text, params object[] args);

		/// <summary>
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/>.
		/// </summary>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <returns>The translated text.</returns>
		string GetPluralString(string text, string pluralText, long n);

		/// <summary>
		/// Alias of <see cref="GetPluralString(string, string, long)"/>.
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/>.
		/// </summary>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <returns>The translated text.</returns>
		string _n(string text, string pluralText, long n);

		/// <summary>
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/>.
		/// </summary>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string GetPluralString(string text, string pluralText, long n, params object[] args);

		/// <summary>
		/// Alias of <see cref="GetPluralString(string, string, long)"/>.
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/>.
		/// </summary>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string _n(string text, string pluralText, long n, params object[] args);

		/// <summary>
		/// Returns <paramref name="text"/> translated into the selected language using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The text to translate.</param>
		/// <returns>The translated text.</returns>
		string GetParticularString(string context, string text);

		/// <summary>
		/// Alias of <see cref="GetParticularString(string, string)"/>.
		/// Returns <paramref name="text"/> translated into the selected language using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The text to translate.</param>
		/// <returns>The translated text.</returns>
		string _p(string context, string text);

		/// <summary>
		/// Returns <paramref name="text"/> translated into the selected language using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The text to translate.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string GetParticularString(string context, string text, params object[] args);

		/// <summary>
		/// Alias of <see cref="GetParticularString(string, string)"/>.
		/// Returns <paramref name="text"/> translated into the selected language using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The text to translate.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string _p(string context, string text, params object[] args);

		/// <summary>
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/> using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <returns>The translated text.</returns>
		string GetParticularPluralString(string context, string text, string pluralText, long n);

		/// <summary>
		/// Alias of <see cref="GetParticularPluralString(string, string, string, long)"/>.
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/> using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <returns>The translated text.</returns>
		string _pn(string context, string text, string pluralText, long n);

		/// <summary>
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/> using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string GetParticularPluralString(string context, string text, string pluralText, long n, params object[] args);

		/// <summary>
		/// Alias of <see cref="GetParticularPluralString(string, string, string, long, object[])"/>.
		/// Returns the plural form for <paramref name="n"/> of the translation of <paramref name="text"/> using given <paramref name="context"/>.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="text">The singular form of message to translate.</param>
		/// <param name="pluralText">The plural form of message to translate.</param>
		/// <param name="n">The value that determines the plural form.</param>
		/// <param name="args">The optional arguments for <see cref="string.Format(string, object[])"/> method.</param>
		/// <returns>The translated text.</returns>
		string _pn(string context, string text, string pluralText, long n, params object[] args);
	}
}
