using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurfingRedone;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_User_AddFunds()
        {
            //arrange
            User u1 = new User() { FirstName = "Paul", Balance = 100 };

            double expectedBalance = 150;
            //act
            u1.AddFunds(50);

            //assert
            Assert.AreEqual(expectedBalance, u1.Balance);
        }
    }
}