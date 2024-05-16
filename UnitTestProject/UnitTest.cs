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
            string validEmailAddress = "9teamfreelance@mail.ru";
            string invalidEmailAddress = "invalid_email";
            string message = "";
            string filename = "ListOfRecomendations.txt";
            ;
            // Act
            ForUnitTests.CheckSendEmail(validEmailAddress, message, filename);
            ForUnitTests.CheckSendEmail(invalidEmailAddress, message, filename);
        }

        [TestMethod]
        public void TestSurnameTextChange() //���
        {
            // Arrange
            string message1 = "���� ����� �� ������ ���� ������";
            string message2 = "��� �� ������ ��������� �����";

            //Act
            ForUnitTests.Test_Surname_TextChange(message1, message2);
        }

        [TestMethod]
        public void TestPatronomicTextChanged() //�������
        {
            // Arrange
            string message1 = "���� ������� �� ������ ���� ������";
            string message2 = "������� �� ������ ��������� �����";

            //Act
            ForUnitTests.Test_Patronomic_TextChanged(message1, message2);
        }

        [TestMethod]
        public void TestRloginTextChange() //��������
        {
            //Arrange
            string message1 = "�������� �� ������ ��������� �����";

            //Act 
            ForUnitTests.Test_Rlogin_TextChange(message1);
        }

        [TestMethod]
        public void Test_REmail_TextChange()
        {
            //Arrange
            string message1 = "���� ����� �� ������ ���� ������";
            string message2 = "���� ������ �� ������ ���� ������";

            //Act
            ForUnitTests.Test_REmail_TextChange(message1, message2);
        }

        [TestMethod]
        public void Test_Hasing()
        {
            //Accert
            string data = "dataa";

            //Act
            ForUnitTests.Test_Hashing(data);
        }

        [TestMethod]
        public void Test_LogInInfo()
        {
            //Accret
            bool allowed = true;
            Guid uId = new Guid();

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