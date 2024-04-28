namespace freelance
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CheckLocalisated()
        {
            string key = "key";
            var result = "value";
            var res = ForUnitTests.CheckLocalization(key);
            Assert.AreEqual(result, res);
        }
        [TestMethod]
        public void TestMailMessage()
        {
            // Arrange
            string validEmailAddress = "test@example.com";
            string invalidEmailAddress = "invalid_email";
            string message = "lhkdjhhfj";

            // Act
            ForUnitTests.CheckSendEmail(validEmailAddress, message);
            ForUnitTests.CheckSendEmail(invalidEmailAddress, message);
        }

        [TestMethod]
        public void TestSurnameTextChange() //имя
        {
            // Arrange
            string message1 = "Поле имени не должно быть пустым";
            string message2 = "Имя не должно содержать цифры";

            //Act
            ForUnitTests.Test_Surname_TextChange(message1, message2);
        }

        [TestMethod]
        public void TestPatronomicTextChanged() //фамилия
        {
            // Arrange
            string message1 = "Поле фамилии не должно быть пустым";
            string message2 = "Фамилия не должна содержать цифры";

            //Act
            ForUnitTests.Test_Patronomic_TextChanged(message1, message2);
        }

        [TestMethod]
        public void TestRloginTextChange() //отчество
        {
            //Arrange
            string message1 = "Отчество не должно содержать цифры";

            //Act 
            ForUnitTests.Test_Rlogin_TextChange(message1);
        }

        [TestMethod]
        public void Test_REmail_TextChange()
        {
            //Arrange
            string message1 = "Поле логин не должно быть пустым";
            string message2 = "Поле пароль не должно быть пустым";

            //Act
            ForUnitTests.Test_REmail_TextChange(message1, message2);
        }

        [TestMethod]
        public void Test_Hasing()
        {
            //Accert
            string data = "dataa";

            //Act
            ForUnitTests.Test_Hasing(data);
        }

        [TestMethod]
        public void Test_LogInInfo()
        {
            //Accret
            bool allowed = true;
            int uId = 1;

            //Act
            ForUnitTests.Test_LogInInfo(allowed, uId);
        }

        [TestMethod]
        public void Test_LoadingCustomFont()
        {
            //Assert
            int fontsize = 14;

            //Act
            ForUnitTests.Test_LoadingCustomFont(fontsize);
        }

        [TestMethod]
        public void Test_GenerateNewPassword()
        {
            ForUnitTests.TestGenerateNewPassword();
        }
    }
}