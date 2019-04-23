using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class TestNumberTest
  {
    [TestMethod]
    public void IsNumber_NumberDivisibleByThree_True()
    {
      TestNumber testNumber = new TestNumber();
      Assert.AreEqual(true, testNumber.IsNumber(3));
    }
  }
}
