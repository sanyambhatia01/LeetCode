using LeetCode;
using PasswordVerifier;

namespace PasswordVerifierTest
{
    public class PasswordTest
    {
        [Theory]
        [InlineData("oausgdsa")]
        [InlineData("appleball123")]
        [InlineData("Abc@123")]
        [InlineData("oongaboonga2323")]
        [InlineData("tajikistan66")]
        [InlineData("france")]
        [InlineData("APPLE1PAD")]
        [InlineData("   ")]
        [InlineData("astdvhj")]
        public void Password_IsNotValid_ThrowException(string input)
        {
            //arrange
            PasswordVerify passwordVerify = new PasswordVerify();
            // act & assert
            Assert.Throws<ArgumentException>(() => PasswordVerify.PasswordCheck(input));
        }
    }
}