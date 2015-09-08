using NUnit.Framework;

namespace RandomUtils.Test
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void TestNextBoolean()
		{
			Assert.IsTrue(RandomUtils.NextBoolean() is bool);
		}
	}
}
