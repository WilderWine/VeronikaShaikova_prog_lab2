using NUnit.Framework;
using ShaikovaVeronika_Lab2;

namespace zTesr1
{
    
    public class Tests
    {

        [Test]
        public void returnResTest1()
        {
            int a = 18, b = 18, expect = 0;
            Funcs c = new Funcs();

            int actual = c.returnRes(a, b);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void returnResTest2()
        {
            int a = 18, b = 465, expect = a;
            Funcs c = new Funcs();

            int actual = c.returnRes(a, b);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void parseInFunv()
        {
            
            Funcs c = new Funcs();
            string a = "155";
            int expect = 155;

            int actual = c.parseInFunc(a);

            Assert.AreEqual(expect, actual);
        }

    }
}