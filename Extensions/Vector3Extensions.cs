using System;
using JetBrains.Annotations;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Core.Extensions
{
	[PublicAPI]
	public static class Vector3Extensions
	{
		public static Vector3 TranslateDir(this Vector3 pos, float angleInDegrees, float distance) =>
			new Vector3(
				pos.X + (float)Math.Cos(angleInDegrees.ToRadians()) * distance,
				pos.Y + (float)Math.Sin(angleInDegrees.ToRadians()) * distance,
				pos.Z
			);

		public static Vector3 Lerp(Vector3 pos1, Vector3 pos2, float normalizedInterval) =>
			new Vector3(
				pos1.X.Lerp(pos2.X, normalizedInterval),
				pos1.Y.Lerp(pos2.Y, normalizedInterval),
				pos1.Z.Lerp(pos2.Z, normalizedInterval)
			);

		public static Vector3 InFrontOf(this Vector3 position, float heading, float distance) => position.TranslateDir(heading + 90, distance);
	}
}
