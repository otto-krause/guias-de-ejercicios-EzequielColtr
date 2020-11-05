using NUnit.Framework;
using Ejercicio;
using System;

namespace Testing
{
    public class Tests
    {

        private Heroe Endeavor;

        private Quirk HellFlame;

        [SetUp]
        public void Setup()
        {
            HellFlame = new Quirk(50,false,"HellFlame");

            Endeavor = new Heroe(HellFlame,15,0,true);

        }

        [Test]
        public void QuirkEsPeligroso()
        {
            Assert.IsFalse(HellFlame.esPeligroso());
        }

        
    }
}