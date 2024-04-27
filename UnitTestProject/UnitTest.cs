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
        public void TestCheckDislikedPerformers()
        {
            //Arrange
            string message1 = "�� ��� ��������� ���������� � �������";

            //Act
            ForUnitTests.TestCheckDislikedPerformers(message1);
        }

        [TestMethod]
        public void TestAddDislikeToPerformer()
        {
            //Arrange
            string message1 = "��������� ������� �������� � '�������'";

            //Act
            ForUnitTests.TestAddDislikeToPerformer(message1);
        }

        [TestMethod]
        public void TestAddLikeIfPerformerNotLiked()
        {
            //Arrange
            string message1 = "�� ��� ��������� ���������� � '���������'";

            //Act
            ForUnitTests.TestAddLikedPerformers(message1);
        }

        [TestMethod]
        public void TestAddLikedPerformers()
        {
            //Arrange
            string message1 = "��������� ������� �������� � '���������'";

            //Act
            ForUnitTests.TestAddDislikeToPerformer(message1);
        }
    }

}