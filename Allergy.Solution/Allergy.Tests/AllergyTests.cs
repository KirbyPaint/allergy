using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergy.Score;

namespace Allergy.Tests
{
    [TestClass]
    public class AllergiesTests
    {
        [TestMethod]
        public void GetScore_ReturnTheUsersScore_True()
        {
            Scores testScore = new Scores();
            testScore.SetScore(100);
            Assert.AreEqual(100, testScore.GetScore()); 
        }
    }
}