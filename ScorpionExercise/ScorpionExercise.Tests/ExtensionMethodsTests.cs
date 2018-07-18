using NUnit.Framework;
using System.Collections.Generic;

namespace ScorpionExercise.Tests
{
    public class MainTests
    {
        [TestFixture]
        public class GroupingTests
        {
            [Test]
            public void ChunksAreCorrectSize16()
            {
                var result = "1111222233334444".Chunk(16);
                var expected = new List<string>() { "1111222233334444" };
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void ChunksAreCorrectSize2()
            {
                var result = "1111222233334444".Chunk(2);
                var expected = new List<string>() { "11", "11", "22", "22", "33", "33", "44", "44" };
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void ChunksAreCorrectSize4()
            {
                var result = "1111222233334444".Chunk(4);
                var expected = new List<string>() { "1111", "2222", "3333", "4444" };
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void ChunksAreCorrectSize5()
            {
                var result = "1111222233334444".Chunk(4);
                var expected = new List<string>() { "11112", "22233", "33444", "4" };
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void ChunksAreCorrectSize100()
            {
                var result = "1111222233334444".Chunk(100);
                var expected = new List<string>() { "1111222233334444" };
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void ZeroSizedString()
            {
                var result = "".Chunk(10);
                var expected = new List<string>();
                Assert.That(result, Is.EquivalentTo(expected));
            }

            [Test]
            public void CatchesEdgeCaseofEmptyGrouping()
            {
                Assert.Throws<InvalidGroupingSizeException>(() => "1111222233334444".Chunk(0));
            }
        }
    }
}