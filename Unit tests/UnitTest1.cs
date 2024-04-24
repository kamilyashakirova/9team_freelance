using System.Windows.Forms;
namespace freelance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckLocalisated()
        {
            string key = "hello";
            var ressult = "Bonjour"
            string filepath = "../../../Localization/check.csv";
            var res = ForUnitTests.CheckBoxLocalizated(filepath, key);
            Assert.AreEqual(ressult, res);
        }
    }
}
