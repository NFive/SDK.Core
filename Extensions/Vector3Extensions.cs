using JetBrains.Annotations;
using NFive.SDK.Core.Models;
using System;

namespace NFive.SDK.Core.Extensions
{
	[PublicAPI]
	public static class Vector3Extensions
	{
		/// <summary>
		/// Translates the <see cref="Vector3" /> by the specified angle and distance.
		/// </summary>
		/// <param name="pos">The position.</param>
		/// <param name="angleInDegrees">The angle in degrees.</param>
		/// <param name="distance">The distance.</param>
		/// <returns>The translated <see cref="Vector3" />.</returns>
		public static Vector3 TranslateDir(this Vector3 pos, float angleInDegrees, float distance) =>
			new Vector3(
				pos.X + (float)Math.Cos(angleInDegrees.ToRadians()) * distance,
				pos.Y + (float)Math.Sin(angleInDegrees.ToRadians()) * distance,
				pos.Z
			);

		/// <summary>
		/// Applies a lerp function to two specified <see cref="Vector3" />s with a specified normal interval.
		/// </summary>
		/// <param name="pos1">The start <see cref="Vector3" /> of the lerp function.</param>
		/// <param name="pos2">The end <see cref="Vector3" /> of the lerp function.</param>
		/// <param name="normalizedInterval">The normalized interval.</param>
		/// <returns>The resulting <see cref="Vector3" /></returns>
		/// <remarks>See <see href="https://en.wikipedia.org/wiki/Linear_interpolation" /></remarks>
		public static Vector3 Lerp(this Vector3 pos1, Vector3 pos2, float normalizedInterval) =>
			new Vector3(
				pos1.X.Lerp(pos2.X, normalizedInterval),
				pos1.Y.Lerp(pos2.Y, normalizedInterval),
				pos1.Z.Lerp(pos2.Z, normalizedInterval)
			);

		/// <summary>
		/// Returns a <see cref="Core.Models.Vector2" /> rotated around a specified <see cref="Core.Models.Vector3" /> position by
		/// a specified angle and radius.
		/// </summary>
		/// <param name="position">The position to rotate around.</param>
		/// <param name="radius">The radius.</param>
		/// <param name="angle">The angle.</param>
		/// <returns>The <see cref="Core.Models.Vector2" />.</returns>
		public static Vector2 RotateAround(this Vector3 position, float radius, float angle) =>
			new Vector2(
				position.X + radius * (float)Math.Cos(angle * Math.PI / 180),
				position.Y - radius * (float)Math.Sin(angle * Math.PI / 180)
			);

		public static Vector3 InFrontOf(this Vector3 position, float heading, float distance) => position.TranslateDir(heading + 90, distance);

		/// <summary>
		/// Converts to <see cref="Position" />.
		/// </summary>
		/// <param name="vector3">The <see cref="Vector3" />.</param>
		/// <returns>The <see cref="Position" /></returns>
		public static Position ToPosition(this Vector3 vector3) => new Position(vector3.X, vector3.Y, vector3.Z);
	}
}
