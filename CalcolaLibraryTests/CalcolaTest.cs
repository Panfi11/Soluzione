using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolaLibrary;

namespace CalcolaLibraryTests
{
    [TestClass]
    public class CalcolaTest
    {
        [DataTestMethod]
        [DataRow(5,10)]
        [DataRow(-3,-6)]
        [DataRow(300,600)]
        [DataRow(1234,2468)]
        public void RaddoppiaTest(double num, double rispaspettata)
        {
            double riscalcolato = Calcola.Raddoppia(num);
            Assert.AreEqual(rispaspettata, riscalcolato);
        }
        public void SommaMoneteTest(double[] monete)
        {
            double[] moneta = new double[2] { 20, 34 };
            double risaspettato = 54;
            double riscalcolato = Calcola.SommaMonete(monete);
            Assert.AreEqual(risaspettato, riscalcolato);
        }
    }
}
