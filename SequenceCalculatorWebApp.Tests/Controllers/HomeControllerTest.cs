using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceCalculatorWebApp;
using SequenceCalculatorWebApp.Controllers;

namespace SequenceCalculatorWebApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Can_Pass_Integer_As_Parameter_To_Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(24) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllNumbers_Should_Return_All_Numbers_And_Including_Number_Entered()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var allNumbers = privateHomeControler.Invoke("GetAllNumbers", 5) as List<int>;

            // Assert for count
            Assert.AreEqual(6, allNumbers.Count);

            // Assert for containing entered number
            Assert.IsTrue(allNumbers.Contains(5));
        }

        [TestMethod]
        public void IsDivisible_Should_Return_True_For_EvenNumber()
        {
            // Arrange
            HomeController controller = new HomeController();
            int dividend = 24;
            int divisor = 2;

            // Act
            bool result = controller.IsDivisble(dividend, divisor);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetOddNumbers_Should_Return_All_OddNumbers_Upto_Number_Entered()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var allNumbers = privateHomeControler.Invoke("GetOddNumbers", 5) as List<int>;

            // Assert
            Assert.AreEqual(3, allNumbers.Count);

            Assert.IsTrue(allNumbers.Contains(5));
        }

        [TestMethod]
        public void GetEvenNumbers_Should_Return_All_EvenNumbers_Upto_Number_Entered()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var allNumbers = privateHomeControler.Invoke("GetEvenNumbers", 4) as List<int>;

            // Assert
            Assert.AreEqual(3, allNumbers.Count);

            Assert.IsTrue(allNumbers.Contains(4));
        }

        [TestMethod]
        public void GetCustomSequence_Should_Return_All_Numbers_Upto_Number_Entered()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var customSequence = privateHomeControler.Invoke("GetCustomSequence", 9) as List<string>;

            // Assert
            Assert.AreEqual(10, customSequence.Count);
        }

        [TestMethod]
        public void GetCustomSequence_Should_Return_C_If_Number_Is_Multiple_Of_Three()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var customSequence = privateHomeControler.Invoke("GetCustomSequence", 4) as List<string>;

            // Assert
            Assert.AreEqual(3, customSequence.IndexOf("C"));
        }

        [TestMethod]
        public void GetCustomSequence_Should_Return_E_If_Number_Is_Multiple_Of_Five()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var customSequence = privateHomeControler.Invoke("GetCustomSequence", 10) as List<string>;

            // Assert
            Assert.AreEqual(5, customSequence.IndexOf("E"));
        }

        [TestMethod]
        public void GetCustomSequence_Should_Return_Z_If_Number_Is_Multiple_Of_Three_And_Five()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var customSequence = privateHomeControler.Invoke("GetCustomSequence", 15) as List<string>;

            // Assert to verify 0 is multiple of every number
            Assert.AreEqual(0, customSequence.IndexOf("Z"));

            Assert.AreEqual(15, customSequence.IndexOf("Z",1));
        }

        [TestMethod]
        public void FibonacciNumber_Should_Return_Accurate_Value_For_Every_Integer()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var fibonacciResult = privateHomeControler.Invoke("FibonacciNumber", 92);

            // Assert 
            Assert.AreEqual(Convert.ToInt64(fibonacciResult), 7540113804746346429);
        }

        [TestMethod]
        public void GetAllFibonacciNumbers_Should_Return_All_FibonacciNumbers_Upto_And_Including_The_Number_Entered()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var fibonacciResult = privateHomeControler.Invoke("GetAllFibonacciNumbers", 9) as List<long>;

            // Assert to verify count
            Assert.AreEqual(fibonacciResult.Count, 10);

            //Assert to verify included fibonacci of entered number
            Assert.AreEqual(fibonacciResult.IndexOf(34), 9);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetAllFibonacciNumbers_Should_Return_Exception_Message_If_Number_Exceeded_92()
        {
            // Arrange
            PrivateObject privateHomeControler = new PrivateObject(typeof(HomeController));

            // Act
            var fibonacciResult = privateHomeControler.Invoke("GetAllFibonacciNumbers", 95) ;
        }
    }
}
