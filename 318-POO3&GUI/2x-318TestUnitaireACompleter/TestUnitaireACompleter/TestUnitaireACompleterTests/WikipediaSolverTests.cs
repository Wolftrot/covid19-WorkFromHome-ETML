//ETML
//Auteur : JMY  
//Date : 2017
//Description : Tests
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitaireACompleter.Tests
{
    [TestClass()]
    public class WikipediaSolverTests
    {
        private Equation equation;

        [TestMethod()]
        public void WikipediaSolverTest_Constructor()
        {
            //TODO
            Assert.Fail();
        }

        [TestMethod()]
        public void computeDiscriminantTest()
        {
            //TODO
            Assert.Fail();
        }

        [TestMethod()]
        public void isSolvableTest_NotSolvable()
        {
            //Arrange
            int a = 2;
            int b = -16;
            int c = 1500;
            WikipediaSolver solver = new WikipediaSolver(new Equation(a, b, c));

            //Act
            bool result = solver.isSolvable();

            //Assert
            Assert.AreEqual(false,result);
        }

        [TestMethod()]
        public void isSolvableTest_Solvable()
        {
            //Arrange
            int a = 2;
            int b = -16;
            int c = 12;
            WikipediaSolver solver = new WikipediaSolver(new Equation(a, b, c));

            //Act
            bool result = solver.isSolvable();

            //Assert
            //TODO
            Assert.Fail();
        }

        [TestMethod()]
        public void solveTest_NoSolution()
        {
            //Arrange
            int a = 2;
            int b = -16;
            int c = 1500;
            WikipediaSolver solver = new WikipediaSolver(new Equation(a, b, c));

            //Act
            double[] result = solver.solve();

            //Assert
            Assert.AreEqual(0, result.Length);
        }

        [TestMethod()]
        public void solveTest_1Solution()
        {
            //Arrange
            int a = 2;
            int b = -16;
            int c = 1500;
            WikipediaSolver solver = new WikipediaSolver(new Equation(a, b, c));

            //Act
            double[] result = solver.solve();

            //Assert
            Assert.AreEqual(1, result.Length);
            Assert.AreEqual(84, result[0]);
        }

        [TestMethod()]
        public void solveTest_2Solution()
        {
            //Arrange
            int a = 2;
            int b = -16;
            int c = 1500;
            WikipediaSolver solver = new WikipediaSolver(new Equation(a, b, c));

            //Act
            double[] result = solver.solve();

            //Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(84, result[0]);
            Assert.AreEqual(85, result[1]);
        }

        //TODO: Le code devrait renvoyer une exception
        [TestMethod(),ExpectedException(typeof(ArithmeticException))]
        public void solveTest_MaxInt()
        {
            //Arrange
            int a = 5;
            int b = int.MaxValue;
            int c = 9;
            equation = new Equation(a, b, c);
            WikipediaSolver solver = new WikipediaSolver(equation);

            //Act
            int result = solver.computeDiscriminant();

            //Assert
            Assert.AreEqual(Convert.ToInt64(b)*b-(4*a*c),result);
        }
    }
}