//ETML
//Auteur : JMY  
//Date : 2017
//Description : Tests
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaireACompleter.Tests
{
    [TestClass()]
    public class EquationTests
    {
        [TestMethod()]
        public void EquationTest_StringConstructor()
        {
            //Arrange
            int a = 5;
            int b = 2;
            int c = -9;
            string equationString = a + "x² + " + b + "x " + c;
            Equation equation;

            //Act
            equation = new Equation(equationString);

            //Assert
            Assert.AreEqual(a, equation.A);
            Assert.AreEqual(b, equation.B);
            Assert.AreEqual(c, equation.C);
        }

        [TestMethod()]
        public void EquationTest_IntConstructor()
        {
            //Arrange
            int a = 5;
            int b = 2;
            int c = 9;
            Equation equation;

            //Act
            equation = new Equation(a,b,c);

            //Assert
            Assert.AreEqual(a, equation.A);
            Assert.AreEqual(b, equation.B);
            Assert.AreEqual(c, equation.C);
        }
    }
}