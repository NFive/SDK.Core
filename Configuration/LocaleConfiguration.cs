namespace NFive.SDK.Core.Configuration
{
    using JetBrains.Annotations;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    
    public class LocaleConfiguration
	{
		public List<CultureInfo> Culture { get; set; }

		public TimeZoneInfo TimeZone { get; set; }
	}
}
