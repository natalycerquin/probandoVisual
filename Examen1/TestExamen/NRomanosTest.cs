using Examen1;
using NUnit.Framework;

namespace TestExamen
{
    public class NRomanosTest
    {
       

        [Test]
        public void DevuevelUnoEnRomanos()
        {

            var num = new NumerosRomanos();

            var setN = 1;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("I", result);
        }
        [Test]
        public void DevuevelDosEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 2;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("II", result);
        }
        [Test]
        public void DevueveTresEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 3;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("III", result);
        }
        [Test]
        public void DevueveCuatroEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 4;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("IV", result);
        }
        [Test]
        public void DevueveCincoEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 5;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("V", result);
        }
        [Test]
        public void DevueveSeisEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 6;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("VI", result);
        }
        [Test]
        public void DevueveSieteEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 7;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("VII", result);
        }
        [Test]
        public void DevueveOchoEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 8;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("VIII", result);
        }
        [Test]
        public void DevueveNueveEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 9;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("IX", result);
        }
        [Test]
        public void DevueveDiesEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 10;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("X", result);
        }
        [Test]
        public void DevueveOnceEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 11;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("II", result);
        }
        [Test]
        public void DevueveDoceEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 12;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("XI", result);
        }
        [Test]
        public void DevueveTreceEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 13;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("XIII", result);
        }
        [Test]
        public void DevueveCatorceEnRomanos()
        {
            Assert.Pass();

            var num = new NumerosRomanos();

            var setN = 14;

            var result = num.devolverNuemero(setN);

            Assert.AreEqual("XIV", result);
        }
    }
}