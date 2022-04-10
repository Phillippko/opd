using NUnit.Framework;
using System.Diagnostics;

namespace TestTask2_2
{
    public class Tests
    {

        [Test]
        public void TestCountDownWithTwoSubscribers()
        {
            Stopwatch stopWatch = new Stopwatch();
            CentralElectionCommission commission = new CentralElectionCommission();
            commission.subscribe(new HonestObserver("ִמזהü"));
            commission.subscribe(new DishonestObserver("ײאנüדנאה"));

            stopWatch.Start();
            commission.notify(100, "ֲבנמס");
            commission.notify(100, "ֲבנמס");
            stopWatch.Stop();

            Assert.IsTrue(stopWatch.Elapsed.TotalMilliseconds >= 200);
            Assert.IsTrue(stopWatch.Elapsed.TotalSeconds < 300);
        }

    }
}