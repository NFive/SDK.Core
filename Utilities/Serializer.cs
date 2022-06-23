namespace NFive.SDK.Core.Utilities
{
    using JetBrains.Annotations;
    using Newtonsoft.Json;

	/// <summary>
	/// Utilities to convert objects to and from JSON strings.
	/// </summary>
	[PublicAPI]
	public class Serializer
	{
		/// <summary>Gets or sets the formatting option for the serializer.</summary>
		/// <value>The formatting option.</value>
		public Formatting Formatting { get; set; } = Formatting.None;

		/// <summary>Gets or sets the settings for the serializer.</summary>
		/// <value>The serializer settings.</value>
		public JsonSerializerSettings Settings { get; set; }

		/// <summary>
		/// Serializes the specified object to JSON.
		/// </summary>
		/// <param name="obj">The object to serialize.</param>
		/// <returns>The JSON representation of the object.</returns>
		public string Serialize(object obj) => JsonConvert.SerializeObject(obj, this.Formatting, this.Settings);

		/// <summary>
		/// Deserializes the specified JSON to a type.
		/// </summary>
		/// <typeparam name="T">The type to deserialize the JSON as.</typeparam>
		/// <param name="json">The JSON to deserialize.</param>
		/// <returns>The deserialized object.</returns>
		public T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json, this.Settings);
	}
}
