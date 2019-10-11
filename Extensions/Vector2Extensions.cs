using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Core.Extensions
{
	[PublicAPI]
	public static class Vector2Extensions
	{
		public static Vector2 TranslateDir(this Vector2 pos, float angleInDegrees, float distance) =>
			new Vector2(
				pos.X + (float)Math.Cos(angleInDegrees.ToRadians()) * distance,
				pos.Y + (float)Math.Sin(angleInDegrees.ToRadians()) * distance
			);

		public static Vector2 Lerp(this Vector2 pos1, Vector2 pos2, float normalizedInterval) =>
			new Vector2(
				pos1.X.Lerp(pos2.X, normalizedInterval),
				pos1.Y.Lerp(pos2.Y, normalizedInterval)
			);

		public static Vector2 InFrontOf(this Vector2 position, float heading, float distance) => position.TranslateDir(heading + 90, distance);
	}
}
