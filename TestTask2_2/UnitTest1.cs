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
            commission.subscribe(new HonestObserver("�����"));
            commission.subscribe(new DishonestObserver("��������"));

            stopWatch.Start();
            commission.notify(100, "�����");
            commission.notify(100, "�����");
            stopWatch.Stop();

            Assert.IsTrue(stopWatch.Elapsed.TotalMilliseconds >= 200);
            Assert.IsTrue(stopWatch.Elapsed.TotalSeconds < 300);
        }

    }
}