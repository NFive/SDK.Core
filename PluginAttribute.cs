using System;
using JetBrains.Annotations;

namespace NFive.SDK.Core
{
	[PublicAPI]
	[AttributeUsage(AttributeTargets.Assembly)]
	public class PluginAttribute : Attribute { }
}
