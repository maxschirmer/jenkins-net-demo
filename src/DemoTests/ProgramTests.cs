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
  }
}
