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
		/// <returns>the random bool</returns>turns>
		public static bool NextBoolean()
		{
			return NextBoolean(Rand);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed boolean value from the given random sequence.
		/// </summary>
		/// <param name="rand">the Random sequence generator</param>
		/// <returns>the random bool</returns>
		public static bool NextBoolean(Random rand)
		{
			return Convert.ToBoolean(rand.Next(2));
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the Math.random() sequence.
		/// </summary>
		/// <returns>the random double</returns>
		public static double NextDouble()
		{
			return NextDouble(Rand);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the given Random sequence.
		/// </summary>
		/// <param name="rand">the Random sequence generator</param>
		/// <returns>the random double</returns>
		public static double NextDouble(Random rand)
		{
			return rand.NextDouble();
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the Random sequence.
		/// </summary>
		/// <returns>the random float</returns>
		public static float NextFloat()
		{
			return NextFloat(Rand);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed float value between 0.0 and 1.0 from the given Random sequence.
		/// </summary>
		/// <see cref="http://stackoverflow.com/questions/3365337/best-way-to-generate-a-random-float-in-c-sharp"/>
		/// <param name="rand">the Random sequence generator</param>
		/// <returns>the random float</returns>
		public static float NextFloat(Random rand)
		{
			var buffer = new byte[4];
			rand.NextBytes(buffer);
			return BitConverter.ToSingle(buffer, 0);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed int value from the Random sequence.
		/// </summary>
		/// <returns>the random int</returns>
		public static int NextInt()
		{
			return NextInt(Rand);
		}

		/// <summary>
		/// Returns a pseudorandom, uniformly distributed int value between 0 (inclusive) and the specified value (exclusive), from the Random sequence.
		/// </summary>
		/// <param name="n">the specified exclusive max-value </param>
		/// <returns>the random int</returns>
		public static int NextInt(int n)
		{
			return NextInt(Rand, n);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed int value from the given Random sequence.
		/// </summary>
		/// <param name="rand">the Random sequence generator.</param>
		/// <returns>the random int</returns>
		public static int NextInt(Random rand)
		{
			return rand.Next();
		}

		/// <summary>
		/// Returns a pseudorandom, uniformly distributed int value between 0 (inclusive) and the specified value (exclusive), from the given Random sequence.
		/// </summary>
		/// <param name="rand">the Random sequence generator</param>
		/// <param name="n">the specified exclusive max-value </param>
		/// <returns>the random int</returns>
		public static int NextInt(Random rand, int n)
		{
			return rand.Next(n);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed long value from the Random sequence.
		/// </summary>
		/// <returns>the random long</returns>
		public static long NextLong()
		{
			return NextLong(Rand);
		}

		/// <summary>
		/// Returns the Next pseudorandom, uniformly distributed long value from the given Random sequence.
		/// </summary>
		/// <see cref="http://stackoverflow.com/questions/6651554/random-number-in-long-range-is-this-the-way"/>
		/// <seealso cref="http://stackoverflow.com/questions/15463033/c-sharp-randomlong"/>
		/// <param name="rand">the Random sequence generator</param>
		/// <returns>the random long</returns>
		public static long NextLong(Random rand)
		{
			var buf = new byte[8];
			rand.NextBytes(buf);
			return BitConverter.ToInt64(buf, 0);
		}
	}
}
