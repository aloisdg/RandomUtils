using System;

namespace RandomUtils
{
	/// <summary>
	/// RandomUtils is a wrapper that supports all possible Random methods via the Random class and its system-wide Random object.
	/// <see cref="https://commons.apache.org/proper/commons-lang/javadocs/api-2.4/org/apache/commons/lang/math/RandomUtils.html"/>
	/// </summary>
	public static class RandomUtils
	{
		private static readonly Random Rand = new Random();

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed boolean value from the Random sequence.
		/// </summary>
		/// <returns></returns>
		public static bool NextBoolean()
		{
			return Convert.ToBoolean(Rand.Next(2));
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed boolean value from the given random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <returns></returns>
		public static bool NextBoolean(Random rand)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the Math.random() sequence.
		/// </summary>
		/// <returns></returns>
		public static double NextDouble()
		{
			return Rand.NextDouble();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the given Random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <returns></returns>
		public static double NextDouble(Random rand)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the Random sequence.
		/// </summary>
		/// <returns></returns>
		public static float NextFloat()
		{
			return Convert.ToSingle(NextDouble());
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the given Random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <returns></returns>
		public static float NextFloat(Random rand)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed int value from the Random sequence.
		/// </summary>
		/// <returns></returns>
		public static int NextInt()
		{
			return Rand.Next();
		}

		/// <summary>
		/// Returns a pseudorandom, uniformly distributed int value between 0 (inclusive) and the specified value (exclusive), from the Random sequence.
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int NextInt(int n)
		{
			return Rand.Next(n);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed int value from the given Random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <returns></returns>
		public static int NextInt(Random rand)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns a pseudorandom, uniformly distributed int value between 0 (inclusive) and the specified value (exclusive), from the given Random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public static int NextInt(Random rand, int n)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed long value from the Random sequence.
		/// </summary>
		/// <returns></returns>
		public static long NextLong()
		{
			return Convert.ToInt64(NextDouble());
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed long value from the given Random sequence.
		/// </summary>
		/// <param name="rand"></param>
		/// <returns></returns>
		public static long NextLong(Random rand)
		{
			throw new NotImplementedException();
		}
	}
}
