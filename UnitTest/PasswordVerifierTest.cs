using LeetCode;
using PasswordVerifier;

namespace PasswordVerifierTest
{
    public class PasswordTest
    {
        [Theory]
        [InlineData("oausgdsa")]
        [InlineData("Passw0rd12!@")]
        [InlineData("appleball123")]
        [InlineData("Abc@123")]
        [InlineData("oongaboonga2323")]
        [InlineData("233@%$aBa")]
        [InlineData("app1#$3B")]
        [InlineData("dkjcnskdcn12@#$23P")]
        [InlineData("tajikistan66")]
        [InlineData("Sanyam@098")]
        [InlineData("france")]
        [InlineData("APPLE1PAD")]
        [InlineData("dmclscAC@%^6")]
        [InlineData("bnGj920&%")]
        [InlineData("Delhi@#00")]
        [InlineData("   ")]
        [InlineData("astdvhj")]
        public void Password_IsValid_ThrowException(string input)
        {
            //arrange
            PasswordVerify passwordVerify = new PasswordVerify();
            // act & assert
            Assert.Throws<ArgumentException>(() => PasswordVerify.PasswordCheck(input));
        }

    }
}