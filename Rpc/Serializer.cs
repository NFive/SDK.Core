using JetBrains.Annotations;
using Newtonsoft.Json;

namespace NFive.SDK.Core.Rpc
{
	/// <summary>
	/// Utilities to convert objects to and from JSON strings.
	/// </summary>
	/// TODO: Convert to ISerializer interface and move Newtonsoft.Json requirement to higher level.
	[PublicAPI]
	public class Serializer
	{
		/// <summary>
		/// Serializes the specified object to JSON.
		/// </summary>
		/// <param name="obj">The object to serialize.</param>
		/// <returns>The JSON representation of the object.</returns>
		public string Serialize(object obj) => JsonConvert.SerializeObject(obj);

		/// <summary>
		/// Deserializes the specified JSON to a type.
		/// </summary>
		/// <typeparam name="T">The type to deserialize the JSON as.</typeparam>
		/// <param name="json">The JSON to deserialize.</param>
		/// <returns>The deserialized object.</returns>
		public T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json);
	}
}
