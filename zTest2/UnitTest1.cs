using NUnit.Framework;
using Lab2_2;

namespace zTest2
{
    public class Tests
    {
        

        [Test]
        public void CheckPointOnBoarder()
        {
            FuncsToo c = new FuncsToo();
            double x = 0, y = 0;
            int actual = c.positionFind(x, y);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPointWithin()
        {
            FuncsToo c = new FuncsToo();
            double x = -4.8, y = 2.9;
            int actual = c.positionFind(x, y);
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckPointOunside()
        {
            FuncsToo c = new FuncsToo();
            double x = 2, y = 6;
            int actual = c.positionFind(x, y);
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
    }
}