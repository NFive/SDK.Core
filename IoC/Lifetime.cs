namespace NFive.SDK.Core.IoC
{
	/// <summary>Lifetime of an object</summary>
	public enum Lifetime
	{
		/// <summary>Return a new object each time the service is request.</summary>
		Transient,
		/// <summary>Same instance for the entire application lifetime.</summary>
		Singleton
	}
}
