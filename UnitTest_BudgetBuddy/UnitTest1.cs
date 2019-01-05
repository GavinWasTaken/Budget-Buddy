using Microsoft.VisualStudio.TestTools.UnitTesting;
using Budget_Buddy;
using System.Collections.Generic;
using Xamarin.Forms.Mocks;

namespace UnitTest_BudgetBuddy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateBasicBudget_Calculatesimplepercentages_ReturnRightPercentages()
        {
            //Arrange
            var mp = new MainPage();
            
            List<double> actual = new List<double>() {50,30,20 };

            //Act
            List<double> expected = mp.getPercents(100);
            //List<double> expected = mp.getPercents(100);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
