using System;
using Dick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaDelSave()
        {
            //Organizar
            Company comp = new Company("hola", 35.35);
            double ValorEsp = 45.35;
            //Actuar
            comp.Save(10);
            double ValorOb = comp.SaveProject;
            //Afirmar
            Assert.AreEqual(ValorEsp, ValorOb);
        }

        [TestMethod]
        public void PruebaDelSpend()
        {
            //Organizar
            Company comp = new Company("hola", 35.35);
            double ValorEsp = 25.35;
            //Actuar
            comp.Spend(10);
            double ValorOb = comp.SaveProject;
            //Afirmar
            Assert.AreEqual(ValorEsp, ValorOb);

        }

        [TestMethod]
        public void PruebaDelChangeName()
        {
            //Organizar
            Company comp = new Company("hola", 35.35);
            string ValorEsp = "Sebas";
            //Actuar
            comp.ChangeName("Sebas");
            string ValorOb = comp.Name;
            //Afirmar
            Assert.AreEqual(ValorEsp, ValorOb);
        }
    }
}
