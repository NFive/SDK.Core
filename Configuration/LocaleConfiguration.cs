using System;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;

namespace NFive.SDK.Core.Configuration
{
	[PublicAPI]
	public class LocaleConfiguration
	{
		public List<CultureInfo> Culture { get; set; }

		public TimeZoneInfo TimeZone { get; set; }
	}
}
