namespace NFive.SDK.Core.Plugins
{
    using JetBrains.Annotations;
    using System;

    [PublicAPI]
	[Serializable]
	public class Repository
	{
		/// <summary>
		/// Gets or sets the repository name.
		/// </summary>
		/// <value>
		/// The repository name.
		/// </value>
		public Name Name { get; set; }

		/// <summary>
		/// Gets or sets the repository type.
		/// </summary>
		/// <value>
		/// The repository type.
		/// </value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the repository path.
		/// </summary>
		/// <value>
		/// The repository path.
		/// </value>
		public string Path { get; set; }

		/// <summary>
		/// Gets or sets the repository URL.
		/// </summary>
		/// <value>
		/// The repository URL.
		/// </value>
		public string Url { get; set; }
	}
}
