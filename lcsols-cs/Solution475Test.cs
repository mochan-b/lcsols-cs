using NUnit.Framework;

namespace Tests
{
    public class Solution475Test
    {
        [Test]
        public void Test1()
        {
            int[] houses = { 1, 2, 3 };
            int[] heaters = { 2 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 1);
        }

        [Test]
        public void Test2()
        {
            int[] houses = { 1, 3, 2 };
            int[] heaters = { 2 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 1);
        }

        [Test]
        public void Test3()
        {
            int[] houses = { 1, 2, 3, 4 };
            int[] heaters = { 1, 4 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 1);
        }

        [Test]
        public void Test4()
        {
            int[] houses = { 1, 5 };
            int[] heaters = { 2 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 3);
        }

        [Test]
        public void Test5()
        {
            int[] houses = { 1, 5 };
            int[] heaters = { 10 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 9);
        }

        [Test]
        public void Test6()
        {
            int[] houses = { 282475249, 622650073, 984943658, 144108930, 470211272, 101027544, 457850878, 458777923 };
            int[] heaters = { 823564440, 115438165, 784484492, 74243042, 114807987, 137522503, 441282327, 16531729, 823378840, 143542612 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 161834419);
        }

        [Test]
        public void Test7()
        {
            int[] houses = { 474833169, 264817709, 998097157, 817129560 };
            int[] heaters = { 197493099, 404280278, 893351816, 505795335 };
            var solution = new lcsols.Solution475();
            var result = solution.FindRadius(houses, heaters);
            Assert.That(result == 104745341);
        }
    }
}