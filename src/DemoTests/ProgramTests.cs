using NUnit.Framework;
using Demo;

namespace DemoTests
{
  [TestFixture]
  public class ProgramTests
  {
    [Test]
    public void Add()
    {
      Assert.AreEqual(42, Program.Add(40, 2));
    }

    [Test]
    public void Subtract()
    {
        Assert.AreEqual(1066, Program.Subtract(1100, 34));
    }
  }
}