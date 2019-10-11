using System;

namespace NFive.SDK.Core.Extensions
{
	public static class NumericExtensions
	{
		public static double ToRadians(this float val) => Math.PI / 180 * val;

		public static bool IsBetween(this float val, float min, float max) => val > min && val < max;

		public static float Lerp(this float v0, float v1, float interval) => (1 - interval) * v0 + interval * v1;
	}
}
