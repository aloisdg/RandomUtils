using System;
using System.Diagnostics;
using NUnit.Framework;

namespace RandomUtils.Test
{
	[TestFixture]
	public class Tests
	{
		private const int Seed = 4;

		[Test]
		public void TestNextBoolean()
		{
			Assert.IsTrue(RandomUtils.NextBoolean(new Random(Seed)) && !RandomUtils.NextBoolean(new Random(Seed - 1)));
		}

		[Test]
		public void TestNextInt()
		{
			Assert.AreEqual(1752227528, (RandomUtils.NextInt(new Random(Seed))));
		}

		[Test]
		public void TestNextLong()
		{
			Assert.AreEqual(496238097881962952, RandomUtils.NextLong(new Random(Seed)));
		}

		[Test]
		public void TestNextFloat()
		{
			Assert.AreEqual(-0.0120300725f, RandomUtils.NextFloat(new Random(Seed)));
		}

		[Test]
		public void TestNextDouble()
		{
			Assert.AreEqual(0.81594452672449147d, RandomUtils.NextDouble(new Random(Seed)));
		}
	}
}
