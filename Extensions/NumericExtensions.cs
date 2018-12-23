using System;

namespace NFive.SDK.Core.Extensions
{

	public static class NumericExtensions
	{
		/// <summary>
		/// Convert to Radians.
		/// </summary>
		/// <param name="val">The value to convert to radians</param>
		/// <returns>The value in radians</returns>
		public static double ToRadians(this float val)
		{
			return (Math.PI / 180) * val;
		}

		public static float Lerp(this float v0, float v1, float interval) => (1 - interval) * v0 + interval * v1;
	}
}
