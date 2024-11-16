
namespace JenkinsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello, World! from David";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                JenkinsProject.ConsoleApp.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }

        }
    }
}