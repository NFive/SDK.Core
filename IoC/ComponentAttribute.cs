using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core.IoC
{
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
	public class ComponentAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets lifetime
		/// </summary>
		public Lifetime Lifetime { get; set; } = Lifetime.Transient;
	}
}
